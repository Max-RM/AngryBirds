param(
    [Parameter(Mandatory = $true)]
    [ValidateSet("win-x86", "win-x64", "win-arm64", "win-arm")]
    [string] $Rid,

    [Parameter(Mandatory = $true)]
    [string] $OutDir,

    [string] $ProjectRoot
)

$ErrorActionPreference = "Stop"

if (-not $ProjectRoot) {
    $ProjectRoot = (Resolve-Path (Join-Path $PSScriptRoot "..")).Path
}

$launcherDir = Join-Path $ProjectRoot "tools\launcher"
$launcherC   = Join-Path $launcherDir "launcher.c"
$launcherRc  = Join-Path $launcherDir "launcher.rc"
$iconIco     = Join-Path $launcherDir "AngryBirds.ico"

if (-not (Test-Path $launcherC)) { throw "Missing launcher.c: $launcherC" }
if (-not (Test-Path $launcherRc)) { throw "Missing launcher.rc: $launcherRc" }
if (-not (Test-Path $iconIco))  { throw "Missing AngryBirds.ico: $iconIco (run scripts\Make-AngryBirds-Icon.ps1 first)" }

if (-not (Test-Path $OutDir)) {
    New-Item -ItemType Directory -Path $OutDir -Force | Out-Null
}

# Map RID -> clang target triple.
$triple = switch ($Rid) {
    "win-x86"   { "i686-w64-windows-gnu" }
    "win-x64"   { "x86_64-w64-windows-gnu" }
    "win-arm64" { "aarch64-w64-windows-gnu" }
    "win-arm"   { "armv7-w64-mingw32" }
}

function Set-PeSubsystem {
    param(
        [Parameter(Mandatory = $true)] [string] $Path,
        [Parameter(Mandatory = $true)]
        [ValidateSet("WindowsGui", "Console")]
        [string] $Subsystem
    )

    $bytes = [System.IO.File]::ReadAllBytes($Path)
    if ($bytes.Length -lt 0x100 -or $bytes[0] -ne 0x4D -or $bytes[1] -ne 0x5A) {
        throw "Not a PE executable: $Path"
    }

    $peOffset = [System.BitConverter]::ToInt32($bytes, 0x3C)
    $optionalHeaderOffset = $peOffset + 24
    $subsystemOffset = $optionalHeaderOffset + 0x44
    $value = if ($Subsystem -eq "WindowsGui") { [UInt16] 2 } else { [UInt16] 3 }
    $subsystemBytes = [System.BitConverter]::GetBytes($value)
    $bytes[$subsystemOffset] = $subsystemBytes[0]
    $bytes[$subsystemOffset + 1] = $subsystemBytes[1]

    $lastError = $null
    for ($attempt = 1; $attempt -le 20; $attempt++) {
        try {
            [System.IO.File]::WriteAllBytes($Path, $bytes)
            return
        } catch {
            $lastError = $_
            Start-Sleep -Milliseconds 250
        }
    }
    throw $lastError
}

# Resolve clang / windres (llvm-mingw). If they are missing, skip silently so
# that CI/users without a compiler still get the cmd/bat launchers.
$clang = $null
try { $clang = Get-Command clang.exe -ErrorAction Stop } catch {}
if (-not $clang) {
    Write-Host "  clang.exe not found on PATH; skipping native exe for $Rid."
    exit 0
}

$windres = $null
try { $windres = Get-Command windres.exe -ErrorAction Stop } catch {
    $candidate = Join-Path (Split-Path -Parent $clang.Source) "windres.exe"
    if (Test-Path $candidate) { $windres = Get-Item $candidate }
}
if (-not $windres) {
    Write-Host "  windres.exe not found; skipping native exe for $Rid."
    exit 0
}

# Probe that this clang actually supports the requested target.
$probeSrc = Join-Path $env:TEMP ("ab_launcher_probe_$Rid" + "_" + $PID + ".c")
$probeExe = Join-Path $env:TEMP ("ab_launcher_probe_$Rid" + "_" + $PID + ".exe")
"int main(void){return 0;}" | Set-Content -Path $probeSrc -Encoding ASCII
& $clang --target=$triple $probeSrc -o $probeExe 2>&1 | Out-Null
$probeOk = ($LASTEXITCODE -eq 0) -and (Test-Path $probeExe)
Remove-Item $probeSrc, $probeExe -ErrorAction SilentlyContinue
if (-not $probeOk) {
    Write-Host "  clang cannot target $triple; skipping native exe for $Rid."
    exit 0
}

$resObj    = Join-Path $launcherDir ("launcher-res-$Rid.o")
$silentExe = Join-Path $OutDir "AngryBirds.exe"
$debugExe  = Join-Path $OutDir "AngryBirds.Debug.exe"

foreach ($old in @($silentExe, $debugExe)) {
    if (Test-Path $old) { Remove-Item -LiteralPath $old -Force }
}

$linkFlags = @("--target=$triple", "-O2", "-municode")
if ($Rid -ne "win-arm") {
    $linkFlags += "-mwindows"
}

Push-Location $launcherDir
try {
    & $windres --target=$triple -i launcher.rc -O coff -o $resObj 2>&1 | Out-Null
    if ($LASTEXITCODE -ne 0) { throw "windres failed to compile launcher.rc for $Rid." }

    & $clang @linkFlags launcher.c $resObj -o $silentExe 2>&1 | Out-Null
    if ($LASTEXITCODE -ne 0 -or -not (Test-Path $silentExe)) {
        throw "clang failed to link launcher for $Rid."
    }

    Copy-Item -LiteralPath $silentExe -Destination $debugExe -Force
    Set-PeSubsystem -Path $silentExe -Subsystem WindowsGui
    Set-PeSubsystem -Path $debugExe  -Subsystem Console
} finally {
    Pop-Location
    Remove-Item $resObj -ErrorAction SilentlyContinue
}

Write-Host ("Built launcher for {0}: {1} + {2}" -f $Rid, $silentExe, $debugExe)

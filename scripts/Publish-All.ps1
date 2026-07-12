param(
    [ValidateSet("win-x64", "win-x86", "win-arm64", "win-arm")]
    [string[]]$Rids = @("win-x64", "win-x86", "win-arm64", "win-arm")
)

$ErrorActionPreference = "Stop"
$Root = Split-Path -Parent $PSScriptRoot
$Project = Join-Path $Root "AngryBirds_WP8_MainDLL\AngryBirds.csproj"
$PublishRoot = Join-Path $Root "publish"
$BundledArmRuntimeRoot = Join-Path $Root "dotnet-runtime-8.0.6-win-arm"

function New-GameLauncher($OutDir) {
    $batPath = Join-Path $OutDir "Start-Game.bat"
    @"
@echo off
cd /d "%~dp0"
if exist "%~dp0shared\Microsoft.WindowsDesktop.App" (
  set DOTNET_ROOT=%~dp0
  set DOTNET_MULTILEVEL_LOOKUP=0
)
if exist "%~dp0dotnet.exe" (
  "%~dp0dotnet.exe" AngryBirds.dll %*
) else (
  dotnet AngryBirds.dll %*
)
if errorlevel 1 pause
"@ | Set-Content -Path $batPath -Encoding ASCII
    Write-Host "  Created launcher: $batPath"

    $cmdPath = Join-Path $OutDir "AngryBirds.cmd"
    @"
@echo off
call "%~dp0Start-Game.bat" %*
"@ | Set-Content -Path $cmdPath -Encoding ASCII
    Write-Host "  Created launcher alias: $cmdPath"
}

function Build-NativeLauncher($Rid, $OutDir) {
    $script = Join-Path $Root "scripts\Build-Launchers.ps1"
    if (-not (Test-Path $script)) {
        Write-Host "  Native launcher skipped: $script not found."
        return $false
    }
    $icon = Join-Path $Root "tools\launcher\AngryBirds.ico"
    if (-not (Test-Path $icon)) {
        Write-Host "  Native launcher skipped: $icon not found (run scripts\Make-AngryBirds-Icon.ps1 first)."
        return $false
    }
    try {
        & $script -Rid $Rid -OutDir $OutDir -ProjectRoot $Root
        if ($LASTEXITCODE -ne 0) {
            Write-Host "  Native launcher skipped: Build-Launchers.ps1 failed for $Rid (exit $LASTEXITCODE)."
            return $false
        }
    } catch {
        Write-Host "  Native launcher skipped for ${Rid}: $($_.Exception.Message)"
        return $false
    }
    return (Test-Path (Join-Path $OutDir "AngryBirds.exe"))
}

function Copy-BundledArmRuntime($OutDir) {
    $runtimeRoot = $BundledArmRuntimeRoot
    if (-not (Test-Path (Join-Path $runtimeRoot "dotnet.exe"))) {
        Write-Host "  ARM32 bundled runtime not found at: $runtimeRoot"
        Write-Host "  Skipping native .NET host/runtime copy for win-arm."
        return
    }

    $runtimeFiles = @("dotnet.exe", "hostfxr.dll")
    foreach ($file in $runtimeFiles) {
        $src = Join-Path $runtimeRoot $file
        if (Test-Path $src) {
            Copy-Item $src (Join-Path $OutDir $file) -Force
        }
    }

    $hostSrc = Join-Path $runtimeRoot "host"
    if (Test-Path $hostSrc) {
        $hostDst = Join-Path $OutDir "host"
        if (Test-Path $hostDst) {
            Remove-Item $hostDst -Recurse -Force
        }
        Copy-Item $hostSrc $hostDst -Recurse -Force
    }

    $sharedDst = Join-Path $OutDir "shared"
    if (Test-Path $sharedDst) {
        Remove-Item $sharedDst -Recurse -Force
    }

    $sharedSrc = Join-Path $runtimeRoot "shared"
    if (Test-Path $sharedSrc) {
        Copy-Item $sharedSrc $sharedDst -Recurse -Force
    }
    else {
        Write-Host "  Note: no bundled runtime at $sharedSrc."
    }

    if (-not (Test-Path (Join-Path $sharedDst "Microsoft.WindowsDesktop.App"))) {
        Write-Host "  ARM32 Desktop runtime not found: $sharedDst\Microsoft.WindowsDesktop.App"
        Write-Host "  (dotnet publish already placed the framework, but the bundled runtime is missing)"
        return
    }
    Write-Host "  Copied bundled .NET host/runtime from $runtimeRoot."
}

foreach ($rid in $Rids) {
    $out = Join-Path $PublishRoot "AngryBirds_$rid"
    Write-Host "Publishing $rid -> $out"

    if ($rid -eq "win-arm") {
        # ARM32 also needs the bundled runtime because the device may not have
        # a system .NET installation.
        dotnet publish $Project -c Release -r $rid --self-contained false -o $out -p:UseAppHost=false
        if ($LASTEXITCODE -ne 0) { throw "Publish failed for $rid (exit $LASTEXITCODE)" }
        Copy-BundledArmRuntime $out
        # Note: if the bundled runtime is not found, the native launcher build
        # will still work but the dotnet.exe/system runtime won't be bundled.
    }
    else {
        dotnet publish $Project -c Release -r $rid --self-contained false -o $out -p:UseAppHost=false
        if ($LASTEXITCODE -ne 0) { throw "Publish failed for $rid (exit $LASTEXITCODE)" }
    }

    New-GameLauncher $out
    $hasExe = Build-NativeLauncher $rid $out

    if (-not $hasExe) {
        Write-Host "  Note: no native exe for $rid (clang not available or icon missing)."
        Write-Host "        Start-Game.bat / AngryBirds.cmd are still present."
    }
}

Write-Host ""
Write-Host "Publish complete. Output folders:"
foreach ($rid in $Rids) {
    $dir = Join-Path $PublishRoot "AngryBirds_$rid"
    $hasExe = Test-Path (Join-Path $dir "AngryBirds.exe")
    Write-Host "  $PublishRoot\AngryBirds_$rid\"
    if ($hasExe) {
        Write-Host "    AngryBirds.exe         (silent native launcher with icon)"
        Write-Host "    AngryBirds.Debug.exe   (console variant for stdout/stderr)"
    }
    Write-Host "    Start-Game.bat         (fallback script)"
    Write-Host "    AngryBirds.cmd         (fallback alias)"
}
Write-Host ""
Write-Host "If native exe files are present, they call 'dotnet AngryBirds.dll' and embed"
Write-Host "the AngryBirds app icon. If clang/llvm-mingw is unavailable, only the scripts"
Write-Host "are produced, which work the same way."
Write-Host "win-arm additionally includes the bundled .NET host/runtime."

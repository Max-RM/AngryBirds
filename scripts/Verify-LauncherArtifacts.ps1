param(
    [string] $PublishRoot = (Join-Path (Split-Path -Parent $PSScriptRoot) "publish")
)

$ErrorActionPreference = "Stop"

function Get-Subsystem {
    param([string] $Path)
    $b = [System.IO.File]::ReadAllBytes($Path)
    $pe = [System.BitConverter]::ToInt32($b, 0x3C)
    return [System.BitConverter]::ToUInt16($b, $pe + 24 + 0x44)
}

Add-Type -AssemblyName System.Drawing

foreach ($rid in @("win-x64", "win-x86", "win-arm64")) {
    $dir = Join-Path $PublishRoot "AngryBirds_$rid"
    $silent = Join-Path $dir "AngryBirds.exe"
    $debug = Join-Path $dir "AngryBirds.Debug.exe"

    if (-not (Test-Path $silent)) { throw "Missing: $silent" }
    if (-not (Test-Path $debug)) { throw "Missing: $debug" }

    $ss = Get-Subsystem -Path $silent
    $sd = Get-Subsystem -Path $debug
    Write-Host ("{0,-10} AngryBirds.exe subsystem={1} (2=GUI)" -f $rid, $ss)
    Write-Host ("{0,-10} AngryBirds.Debug.exe subsystem={1} (3=Console)" -f $rid, $sd)

    if ($ss -ne 2) { throw "$silent is not a GUI subsystem" }
    if ($sd -ne 3) { throw "$debug is not a Console subsystem" }

    $ico = [System.Drawing.Icon]::ExtractAssociatedIcon($silent)
    Write-Host ("{0,-10} icon = {1}x{2}" -f $rid, $ico.Width, $ico.Height)
}

# ARM32: native C launcher built by clang.
$armDir = Join-Path $PublishRoot "AngryBirds_win-arm"
$armSilent = Join-Path $armDir "AngryBirds.exe"
$armDebug = Join-Path $armDir "AngryBirds.Debug.exe"
$armBat = Join-Path $armDir "Start-Game.bat"
if (-not (Test-Path $armBat)) { throw "Missing: $armBat" }

if ((Test-Path $armSilent) -and (Test-Path $armDebug)) {
    $ss = Get-Subsystem -Path $armSilent
    $sd = Get-Subsystem -Path $armDebug
    Write-Host ("win-arm    AngryBirds.exe subsystem={0} (2=GUI)" -f $ss)
    Write-Host ("win-arm    AngryBirds.Debug.exe subsystem={0} (3=Console)" -f $sd)
    if ($ss -ne 2) { throw "$armSilent is not a GUI subsystem" }
    if ($sd -ne 3) { throw "$armDebug is not a Console subsystem" }
    $ico = [System.Drawing.Icon]::ExtractAssociatedIcon($armSilent)
    Write-Host ("win-arm    icon = {0}x{1}" -f $ico.Width, $ico.Height)
} else {
    Write-Host "win-arm    native C launcher not present (Start-Game.bat fallback is)"
}

Write-Host ""
Write-Host "All launcher artifacts look correct."

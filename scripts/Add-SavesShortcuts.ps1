# Add-SavesShortcuts.ps1
#
# Adds an Open-Saves-Folder.bat script and a Saves-Folder.lnk shortcut
# (pointing to %LocalAppData%\AngryBirds) into a game output folder.
#
# Usage:
#   powershell -File .\scripts\Add-SavesShortcuts.ps1 -OutDir <path-to-game-folder>

param(
    [Parameter(Mandatory = $true)]
    [string]$OutDir
)

$ErrorActionPreference = "Stop"

$OutDir = $OutDir.TrimEnd('\')

if (-not (Test-Path -LiteralPath $OutDir)) {
    throw "Output directory not found: $OutDir"
}

$batPath = Join-Path $OutDir "Open-Saves-Folder.bat"
@"
@echo off
start "" explorer "%LocalAppData%\AngryBirds"
"@ | Set-Content -Path $batPath -Encoding ASCII
Write-Host "  Created saves script: $batPath"

$lnkPath = Join-Path $OutDir "Saves-Folder.lnk"
try {
    $ws = New-Object -ComObject WScript.Shell
    $lnk = $ws.CreateShortcut($lnkPath)
    $lnk.TargetPath = Join-Path $env:WINDIR "explorer.exe"
    $lnk.Arguments = "%LocalAppData%\AngryBirds"
    $lnk.WorkingDirectory = $env:LOCALAPPDATA
    $lnk.IconLocation = "explorer.exe,0"
    $lnk.Description = "Open the AngryBirds saves folder (%LocalAppData%\AngryBirds)"
    $lnk.Save()
    Write-Host "  Created saves shortcut: $lnkPath"
}
catch {
    Write-Warning "  Could not create Saves-Folder.lnk: $($_.Exception.Message)"
}

# Add-SavesShortcuts.ps1
#
# Adds an Open-Saves-Folder.bat script and a Saves-Folder.lnk shortcut
# into a game output folder. The target folder is picked from
# AngryBirds.ini (SaveLocation / SavePath) when present:
#   - 0      : %LocalAppData%\AngryBirds
#   - 1      : <game folder> (saves next to AngryBirds.exe)
#   - Custom : the SavePath absolute path
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

$iniPath = Join-Path $OutDir "AngryBirds.ini"
$mode = "local"
$savePath = $null

if (Test-Path -LiteralPath $iniPath) {
    foreach ($raw in Get-Content -LiteralPath $iniPath) {
        $line = $raw.Trim()
        if ($line -eq "" -or $line.StartsWith(";") -or $line.StartsWith("#")) { continue }
        $eq = $line.IndexOf("=")
        if ($eq -le 0) { continue }
        $key = $line.Substring(0, $eq).Trim()
        $val = $line.Substring($eq + 1).Trim()
        if ($key -eq "SaveLocation" -and $val -eq "1") { $mode = "portable" }
        if ($key -eq "SaveLocation" -and $val -eq "Custom") { $mode = "custom" }
        if ($key -eq "SavePath" -and $val -ne "") { $savePath = $val }
    }
}

switch ($mode) {
    "portable" {
        $savesTarget = Join-Path $OutDir "Saves"
        New-Item -ItemType Directory -Path $savesTarget -Force | Out-Null
        $batExplorer = 'explorer "%~dp0Saves"'
    }
    "custom" {
        if ($savePath) {
            $savesTarget = $savePath
        }
        else {
            $mode = "local"
        }
    }
}

if ($mode -eq "local") {
    $savesTarget = "%LocalAppData%\AngryBirds"
    $batExplorer = 'explorer "%LocalAppData%\AngryBirds"'
}

$batPath = Join-Path $OutDir "Open-Saves-Folder.bat"
@"
@echo off
start "" $batExplorer
"@ | Set-Content -Path $batPath -Encoding ASCII
Write-Host "  Created saves script: $batPath (target: $savesTarget)"

$lnkPath = Join-Path $OutDir "Saves-Folder.lnk"
try {
    $ws = New-Object -ComObject WScript.Shell
    $lnk = $ws.CreateShortcut($lnkPath)
    $lnk.TargetPath = Join-Path $env:WINDIR "explorer.exe"
    $lnk.Arguments = $savesTarget
    $lnk.WorkingDirectory = $env:LOCALAPPDATA
    $lnk.IconLocation = "explorer.exe,0"
    $lnk.Description = "Open the AngryBirds saves folder ($savesTarget)"
    $lnk.Save()
    Write-Host "  Created saves shortcut: $lnkPath"
}
catch {
    Write-Warning "  Could not create Saves-Folder.lnk: $($_.Exception.Message)"
}
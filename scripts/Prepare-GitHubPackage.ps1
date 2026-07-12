param(
    [string] $PackageName = "GitHubPackage",
    [switch] $SkipRuntime
)

$ErrorActionPreference = "Stop"

$Root = Resolve-Path (Join-Path $PSScriptRoot "..")
$PackageRoot = Join-Path $Root $PackageName

function Ensure-Dir {
    param([string] $Path)
    if (-not (Test-Path $Path)) {
        New-Item -ItemType Directory -Path $Path -Force | Out-Null
    }
}

function Copy-Tree {
    param(
        [string] $Src,
        [string] $Dst,
        [string[]] $ExcludeDirs = @(),
        [string[]] $ExcludeFiles = @()
    )
    if (-not (Test-Path $Src)) {
        Write-Warning "Source not found: $Src"
        return
    }
    Ensure-Dir $Dst
    $srcLen = $Src.Length
    if (-not $Src.EndsWith("\")) { $srcLen++ }

    Get-ChildItem $Src -Recurse -Force | ForEach-Object {
        $relative = $_.FullName.Substring($srcLen)
        if ($ExcludeDirs | Where-Object { $relative -like "*\$_\*" -or $relative -eq $_ }) {
            return
        }
        if ($ExcludeFiles | Where-Object { $relative -like $_ -or $_.Name -like $_ }) {
            return
        }
        $target = Join-Path $Dst $relative
        if ($_.PSIsContainer) {
            Ensure-Dir $target
        }
        else {
            $targetDir = Split-Path -Parent $target
            Ensure-Dir $targetDir
            Copy-Item -LiteralPath $_.FullName -Destination $target -Force
        }
    }
}

Write-Host "Preparing GitHub package in $PackageRoot ..."

# Clean and recreate the package root.
if (Test-Path $PackageRoot) {
    Remove-Item -LiteralPath $PackageRoot -Recurse -Force
}
Ensure-Dir $PackageRoot

# Top-level project files.
$filesToCopy = @(
    "AngryBirds.sln"
)
foreach ($file in $filesToCopy) {
    $src = Join-Path $Root $file
    if (Test-Path $src) {
        Copy-Item -LiteralPath $src -Destination $PackageRoot -Force
    }
}

# Source code project (exclude generated build artifacts).
Copy-Tree -Src (Join-Path $Root "AngryBirds_WP8_MainDLL") `
          -Dst (Join-Path $PackageRoot "AngryBirds_WP8_MainDLL") `
          -ExcludeDirs @("bin", "obj", ".vs") `
          -ExcludeFiles @("*.user", "*.suo", "*.cache")

# Game assets (Content is referenced by the csproj as ../AngryBirds-v1.5.3.0.0_App/Content).
Copy-Tree -Src (Join-Path $Root "AngryBirds-v1.5.3.0.0_App\Content") `
          -Dst (Join-Path $PackageRoot "AngryBirds-v1.5.3.0.0_App\Content")

# Icon source PNG.
$iconSrc = Join-Path $Root "AngryBirds-v1.5.3.0.0_App\AngryBirds_Tile_173x173.png"
$iconDstDir = Join-Path $PackageRoot "AngryBirds-v1.5.3.0.0_App"
Ensure-Dir $iconDstDir
Copy-Item -LiteralPath $iconSrc -Destination $iconDstDir -Force

# Essential build/publish scripts only (no decompilation/fix scripts).
$essentialScripts = @(
    "Publish-All.ps1",
    "Publish-win-arm.ps1",
    "Publish-win-arm64.ps1",
    "Publish-win-x64.ps1",
    "Publish-win-x86.ps1",
    "Build-Launchers.ps1",
    "Make-AngryBirds-Icon.ps1",
    "Reset-Saves.ps1",
    "Verify-LauncherArtifacts.ps1",
    "Compress-Publish.ps1",
    "Prepare-GitHubPackage.ps1"
)
$scriptsDst = Join-Path $PackageRoot "scripts"
Ensure-Dir $scriptsDst
foreach ($script in $essentialScripts) {
    $src = Join-Path $Root "scripts\$script"
    if (Test-Path $src) {
        Copy-Item -LiteralPath $src -Destination $scriptsDst -Force
    }
}

# Native launcher sources and generated icon.
Copy-Tree -Src (Join-Path $Root "tools\launcher") `
          -Dst (Join-Path $PackageRoot "tools\launcher") `
          -ExcludeFiles @("*.o", "*.x64-test.exe")

# ARM32 bundled runtime (optional, for a fully self-contained package).
# Put it at the package root so Publish-All.ps1 can find it at the expected relative path.
if (-not $SkipRuntime) {
    $runtimeSrc = Join-Path $Root "dotnet-runtime-8.0.6-win-arm"
    if (Test-Path $runtimeSrc) {
        Copy-Tree -Src $runtimeSrc -Dst (Join-Path $PackageRoot "dotnet-runtime-8.0.6-win-arm")
    }
}

# README.md for the package.
$readme = @"
# AngryBirds for Windows (WP8 port)

This is a community port of the Windows Phone 8 version of Angry Birds to
modern .NET 8 / MonoGame WindowsDX.

## Build requirements

- Windows 10/11 x64
- .NET 8 SDK (or later via `RollForward=Major`)
- Optional: llvm-mingw with `clang.exe` and `windres.exe` on PATH if you want
  native `AngryBirds.exe` launchers. Without clang the publish scripts still
  produce working `Start-Game.bat` / `AngryBirds.cmd` launchers.

## Build everything

```powershell
.\scripts\Publish-All.ps1
```

Output will be in `publish\AngryBirds_win-x64`, `publish\AngryBirds_win-x86`,
`publish\AngryBirds_win-arm64`, and `publish\AngryBirds_win-arm`.

## Launch

- With clang-built native launchers: double-click `publish\AngryBirds_<rid>\AngryBirds.exe`.
- Always available: run `publish\AngryBirds_<rid>\Start-Game.bat` or
  `publish\AngryBirds_<rid>\AngryBirds.cmd`.

`AngryBirds.Debug.exe` (where present) is a console-subsystem variant that
shows stdout/stderr.

## Runtime dependency

x64 / x86 / arm64 builds are framework-dependent and need the .NET 8 Desktop
Runtime installed on the target machine (or `dotnet` on PATH).

The win-arm (ARM32) build is bundled with a copy of the .NET 8 Desktop Runtime
for win-arm so it can run on Surface RT / ARM32 Windows tablets without a
system install.

## Project structure

- `AngryBirds_WP8_MainDLL/` — C# game source and project.
- `AngryBirds-v1.5.3.0.0_App/Content/` — original game assets referenced by the
  project.
- `scripts/` — essential build/publish scripts.
- `tools/launcher/` — tiny native C launchers + the embedded icon.
- `dotnet-runtime-8.0.6-win-arm/` — bundled ARM32 .NET runtime (optional).
"@
$readme | Set-Content -Path (Join-Path $PackageRoot "README.md") -Encoding UTF8

# .gitignore.
$gitignore = @"
# Build outputs
**/bin/
**/obj/
**/.vs/
*.user
*.suo

# Publish outputs
publish/

# Package prep / local state
*.log
window.ini
"@
$gitignore | Set-Content -Path (Join-Path $PackageRoot ".gitignore") -Encoding UTF8

Write-Host ""
Write-Host "GitHub package prepared at: $PackageRoot"
Write-Host "To publish from the package, run: .\scripts\Publish-All.ps1"

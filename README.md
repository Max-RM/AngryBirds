# AngryBirds for Windows

This folder is a self-contained recovered source code package for the working
Windows ARM32 port (and x64, x86, ARM64) and based on Windows Phone 7 version.

## Build requirements

- Windows 10/11 x64
- .NET 8 SDK (or later via RollForward=Major)
- Optional: llvm-mingw with clang.exe and windres.exe on PATH if you want
  native AngryBirds.exe launchers. Without clang the publish scripts still
  produce working Start-Game.bat / AngryBirds.cmd launchers.

## Build everything

`powershell
.\scripts\Publish-All.ps1
`

Output will be in publish\AngryBirds_win-x64, publish\AngryBirds_win-x86,
publish\AngryBirds_win-arm64, and publish\AngryBirds_win-arm.

## Launch

- With clang-built native launchers: double-click publish\AngryBirds_<rid>\AngryBirds.exe.
- Always available: run publish\AngryBirds_<rid>\Start-Game.bat or
  publish\AngryBirds_<rid>\AngryBirds.cmd.

AngryBirds.Debug.exe (where present) is a console-subsystem variant that
shows stdout/stderr.

## Runtime dependency

x64 / x86 / arm64 builds are framework-dependent and need the .NET 8 Desktop
Runtime installed on the target machine (or dotnet on PATH).

The win-arm (ARM32) build is bundled with a copy of the .NET 8 Desktop Runtime
for win-arm so it can run on Surface RT / ARM32 Windows tablets without a
system install.

## Project structure

- AngryBirds_WP8_MainDLL/ вЂ” C# game source and project.
- AngryBirds-v1.5.3.0.0_App/Content/ вЂ” original game assets referenced by the
  project.
- scripts/ вЂ” essential build/publish scripts.
- 	ools/launcher/ вЂ” tiny native C launchers + the embedded icon.
- dotnet-runtime-8.0.6-win-arm/ вЂ” bundled ARM32 .NET runtime (optional).

## Todo
Despite the fact that the cutscenes were fixed and the game is now fully playable, I was unable to properly recycle the game window due to the strangeness of the sprites. Therefore, it is not recommended to change the size of the game window now, but it is planned to fix it in the future.

Your saves are located in: %LocalAppData%\AngryBirds

Ported by MaxRM, TNT ENTERTAINMENT inc organization in 2026 on July 11.

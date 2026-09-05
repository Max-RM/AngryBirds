# AngryBirds for Windows

A self-contained recovered source code package for the working Windows port
(x64, x86, ARM64, ARM32) of the Windows Phone 7 Angry Birds (v1.5.3.0).

## Build requirements

- Windows 10/11 x64
- .NET 8 SDK (or later via RollForward=Major)
- Optional: llvm-mingw with clang.exe and windres.exe on PATH if you want
  native AngryBirds.exe launchers. Without clang the publish scripts still
  produce working Start-Game.bat / AngryBirds.cmd launchers.

## Build everything

```
powershell -ExecutionPolicy Bypass -File .\scripts\Publish-All.ps1
```

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

## Saves and the AngryBirds.ini settings file

The game stores its saves (settings.lua, highscores.lua, ...) either in the
system profile or next to the game itself. The choice is made by
AngryBirds.ini, which sits next to AngryBirds.exe and is copied into every
build output automatically:

```
; Lines starting with ";" or "#" are comments.

[Storage]

SaveLocation=0
;SavePath=C:\MyAngryBirdsSaves
```

Available options:

| Setting       | Value  | Effect                                                    |
|---------------|--------|-----------------------------------------------------------|
| SaveLocation  | 0      | Saves in %LocalAppData%\AngryBirds (default after compilation, same as the original game) |
| SaveLocation  | 1      | Saves in the Saves folder in the game's root folder (True Portable) |
| SaveLocation  | Custom | Saves in the folder given by SavePath (absolute path)     |
| SavePath      | <path> | Custom saves folder; used only when SaveLocation=Custom   |

### True Portable mode

Set `SaveLocation=1` and the game keeps its saves in the `Saves` folder in
its own root folder, next to AngryBirds.exe. The whole game folder can then
be copied onto a USB stick and run on any machine - no saves are left behind
in the system profile.

### Custom folder

Set `SaveLocation=Custom` and `SavePath=<absolute path>` to store saves in
any folder you like (for example a OneDrive-synced or network location).

### Moving saves between modes

Saves are plain files. To migrate:

- 0 -> 1: set `SaveLocation=1`, run the game once, close it, then copy the
  contents of %LocalAppData%\AngryBirds into the game's Saves folder.
- 1 -> 0: set `SaveLocation=0` and copy the saves from the game's Saves
  folder back into %LocalAppData%\AngryBirds.

### Saves shortcuts

Every build output contains:

- Open-Saves-Folder.bat - opens the active saves folder (respects the ini).
- Saves-Folder.lnk - same, as a desktop-style shortcut.

## Window

The game window can be freely resized. The game uses full-bleed widescreen:
at wider/taller windows more of the world becomes visible (no black bars)
and the HUD/menus anchor to the visible edges. Touch/mouse input is
remapped to the logical 800x480 canvas, so clicks stay accurate at any size.

Pressing ESC in the main menu asks for confirmation before exiting
(uses the game's own localized "Quit" / "Are you sure?" strings).
In submenus ESC goes back one level as before, and in levels it opens
the pause panel.

### Keep running when inactive

By default the game pauses when its window loses focus (original behavior).
To keep it running while Alt-Tabbed (e.g. no freeze when switching to
another app), set in AngryBirds.ini:

```
[Window]
KeepRunningInBackground=1
```

## Achievements

Achievements work locally without Xbox LIVE and persist in
achievements.json next to AngryBirds.exe. Typing BAGME on the keyboard
awards "Pig Popper" (debug/test cheat). Lists (achievements, leaderboards)
scroll by dragging or with the mouse wheel when the cursor is over the list.

## Project structure

- AngryBirds_WP8_MainDLL/ - C# game source and project (contains AngryBirds.ini).
- AngryBirds-v1.5.3.0.0_App/Content/ - original game assets referenced by the
  project.
- scripts/ - essential build/publish scripts.
  - Publish-All.ps1 - builds all four releases into publish\.
  - Clean-BuildOutput.ps1 - removes compile caches (obj) and empties
    AngryBirds_WP8_MainDLL\bin and publish\ (the folders themselves are kept).
  - Add-SavesShortcuts.ps1 - adds Open-Saves-Folder.bat and Saves-Folder.lnk
    into a game folder. It runs automatically after every build/publish via an
    MSBuild target and respects the AngryBirds.ini save mode.
- tools/launcher/ - tiny native C launchers + the embedded icon.
- dotnet-runtime-8.0.6-win-arm/ - bundled ARM32 .NET runtime (optional).

Ported by MaxRM, TNT ENTERTAINMENT inc organization in 2026 on July 12.

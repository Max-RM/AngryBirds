/*
 * Native launcher for AngryBirds on win-x86 / win-x64 / win-arm64.
 *
 * The .NET 8 SDK already produces a working apphost (AngryBirds.exe) on those
 * RIDs, but it is a plain console-mode exe and shows a console window even
 * for a GUI app. On top of that, the apphost here has been known to crash on
 * some configurations when ANGLE/MonoGame immediately tries to create the
 * graphics device.
 *
 * This launcher:
 *   - finds its own directory;
 *   - prefers the bundled dotnet.exe when present (so it works on machines
 *     without a system .NET runtime);
 *   - falls back to the system "dotnet" on PATH;
 *   - launches `dotnet AngryBirds.dll` and waits for it to exit;
 *   - propagates the exit code.
 *
 * Two variants are produced from the same source:
 *   AngryBirds.exe        - compiled as a Windows GUI subsystem exe (silent)
 *   AngryBirds.Debug.exe  - copy with the PE subsystem patched to Console
 *                           so stdout/stderr from the game are visible.
 *
 * The icon is embedded via launcher.rc and windres. windres 2.39+ supports
 * PNG icons directly, otherwise we fall back to a converted .ico.
 *
 * Build: clang --target=<triple> -O2 -municode launcher.c launcher-res.o -o AngryBirds.exe
 */

#include <windows.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#ifndef LAUNCHER_SUBSYSTEM_WINDOWS
#  define LAUNCHER_SUBSYSTEM_WINDOWS 1
#endif

static int build_dotnet_command_line(wchar_t *out, size_t out_size,
                                     const wchar_t *dir,
                                     const wchar_t *dotnet_exe)
{
    /* Quote both paths so spaces survive. */
    return _snwprintf_s(out, out_size, _TRUNCATE,
                        L"\"%s\" \"%s\\AngryBirds.dll\"",
                        dotnet_exe, dir) > 0 ? 0 : -1;
}

static int build_fallback_command_line(wchar_t *out, size_t out_size,
                                       const wchar_t *dir)
{
    /* No bundled dotnet; rely on PATH. */
    return _snwprintf_s(out, out_size, _TRUNCATE,
                        L"dotnet \"%s\\AngryBirds.dll\"", dir) > 0 ? 0 : -1;
}

static wchar_t *path_combine_alloc(const wchar_t *dir, const wchar_t *name)
{
    size_t need = wcslen(dir) + 1 + wcslen(name) + 1;
    wchar_t *buf = (wchar_t *)malloc(need * sizeof(wchar_t));
    if (!buf) {
        return NULL;
    }
    _snwprintf_s(buf, need, _TRUNCATE, L"%s\\%s", dir, name);
    return buf;
}

static int dotnet_exists(const wchar_t *dir)
{
    wchar_t *path = path_combine_alloc(dir, L"dotnet.exe");
    if (!path) {
        return 0;
    }
    DWORD attr = GetFileAttributesW(path);
    free(path);
    return (attr != INVALID_FILE_ATTRIBUTES) &&
           !(attr & FILE_ATTRIBUTE_DIRECTORY);
}

static void report_error(const wchar_t *title, const wchar_t *body)
{
#if LAUNCHER_SUBSYSTEM_WINDOWS
    MessageBoxW(NULL, body, title, MB_ICONERROR | MB_OK);
#else
    fwprintf(stderr, L"%s: %s\n", title, body);
#endif
}

int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance,
                    wchar_t *lpCmdLine, int nCmdShow)
{
    (void)hInstance;
    (void)hPrevInstance;
    (void)lpCmdLine;
    (void)nCmdShow;

    wchar_t exe_path[MAX_PATH];
    DWORD len = GetModuleFileNameW(NULL, exe_path, MAX_PATH);
    if (len == 0 || len >= MAX_PATH) {
        report_error(L"AngryBirds", L"Cannot determine launcher path.");
        return 1;
    }

    /* Strip the filename so exe_path points at our own directory. */
    wchar_t *slash = exe_path;
    for (wchar_t *p = exe_path; *p; ++p) {
        if (*p == L'\\' || *p == L'/') {
            slash = p + 1;
        }
    }
    *slash = L'\0';

    wchar_t cmd_line[2048];
    int rc;
    if (dotnet_exists(exe_path)) {
        wchar_t *dotnet_path = path_combine_alloc(exe_path, L"dotnet.exe");
        if (!dotnet_path) {
            report_error(L"AngryBirds", L"Out of memory.");
            return 1;
        }
        rc = build_dotnet_command_line(cmd_line, 2048, exe_path, dotnet_path);
        free(dotnet_path);
    } else {
        rc = build_fallback_command_line(cmd_line, 2048, exe_path);
    }
    if (rc != 0) {
        report_error(L"AngryBirds", L"Path too long for the launcher.");
        return 1;
    }

    STARTUPINFOW si;
    ZeroMemory(&si, sizeof(si));
    si.cb = sizeof(si);

    PROCESS_INFORMATION pi;
    ZeroMemory(&pi, sizeof(pi));

    DWORD creation_flags = 0;
#if LAUNCHER_SUBSYSTEM_WINDOWS
    /* Silent variant: do not allocate a console for the child. */
    creation_flags = CREATE_NO_WINDOW;
#endif

    if (!CreateProcessW(NULL, cmd_line, NULL, NULL, FALSE,
                        creation_flags, NULL, exe_path, &si, &pi)) {
        wchar_t msg[320];
        _snwprintf_s(msg, 320, _TRUNCATE,
                     L"Failed to start AngryBirds.dll (error %lu).\n"
                     L"Make sure .NET 8 Desktop Runtime is installed, "
                     L"or that dotnet.exe is bundled next to AngryBirds.exe.",
                     GetLastError());
        report_error(L"AngryBirds", msg);
        return 1;
    }

    WaitForSingleObject(pi.hProcess, INFINITE);

    DWORD exit_code = 0;
    GetExitCodeProcess(pi.hProcess, &exit_code);

    CloseHandle(pi.hProcess);
    CloseHandle(pi.hThread);

    return (int)exit_code;
}

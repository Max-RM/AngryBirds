using System;
using System.IO;

namespace AngryBirds.Port;

internal static class DesktopStorage
{
    private static readonly string Root = ResolveRoot();

    private static string ResolveRoot()
    {
        string root = null;
        try
        {
            string iniPath = Path.Combine(AppContext.BaseDirectory, "AngryBirds.ini");
            if (File.Exists(iniPath))
            {
                string location = ReadIniValue(iniPath, "SaveLocation")?.Trim();
                if (location == "1")
                {
                    root = Path.Combine(AppContext.BaseDirectory, "Saves");
                }
                else if (string.Equals(location, "Custom", StringComparison.OrdinalIgnoreCase))
                {
                    string savePath = ReadIniValue(iniPath, "SavePath");
                    if (!string.IsNullOrWhiteSpace(savePath))
                    {
                        root = savePath.Trim();
                    }
                }
            }
        }
        catch
        {
        }

        if (root == null)
        {
            root = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "AngryBirds");
        }

        Directory.CreateDirectory(root);
        return root;
    }

    private static string ReadIniValue(string iniPath, string key)
    {
        foreach (string raw in File.ReadAllLines(iniPath))
        {
            string line = raw.Trim();
            if (line.Length == 0 || line[0] == ';' || line[0] == '#')
            {
                continue;
            }

            int eq = line.IndexOf('=');
            if (eq <= 0)
            {
                continue;
            }

            if (line.Substring(0, eq).Trim().Equals(key, StringComparison.OrdinalIgnoreCase))
            {
                return line.Substring(eq + 1).Trim();
            }
        }

        return null;
    }

    public static bool ShouldKeepRunningInBackground()
    {
        try
        {
            string iniPath = Path.Combine(AppContext.BaseDirectory, "AngryBirds.ini");
            if (!File.Exists(iniPath)) return false;
            foreach (var raw in File.ReadAllLines(iniPath))
            {
                var line = raw.Trim();
                if (line.Length == 0 || line.StartsWith(";") || line.StartsWith("#") || line.StartsWith("["))
                    continue;
                var idx = line.IndexOf('=');
                if (idx < 0) continue;
                var key = line.Substring(0, idx).Trim();
                var val = line.Substring(idx + 1).Trim();
                if (key.Equals("KeepRunningInBackground", StringComparison.OrdinalIgnoreCase) ||
                    key.Equals("KeepRunningWhenInactive", StringComparison.OrdinalIgnoreCase) ||
                    key.Equals("DisablePauseOnDeactivate", StringComparison.OrdinalIgnoreCase) ||
                    key.Equals("DisableFreezeOnSwitch", StringComparison.OrdinalIgnoreCase) ||
                    key.Equals("BackgroundRun", StringComparison.OrdinalIgnoreCase))
                {
                    if (val == "1" || val.Equals("true", StringComparison.OrdinalIgnoreCase) || val.Equals("yes", StringComparison.OrdinalIgnoreCase))
                        return true;
                    if (val == "0" || val.Equals("false", StringComparison.OrdinalIgnoreCase) || val.Equals("no", StringComparison.OrdinalIgnoreCase))
                        return false;
                }
                if (key.Equals("PauseOnDeactivate", StringComparison.OrdinalIgnoreCase) ||
                    key.Equals("PauseOnFocusLoss", StringComparison.OrdinalIgnoreCase))
                {
                    // Inverted logic
                    if (val == "0" || val.Equals("false", StringComparison.OrdinalIgnoreCase))
                        return true;
                    if (val == "1" || val.Equals("true", StringComparison.OrdinalIgnoreCase))
                        return false;
                }
            }
        }
        catch { }
        return false; // default disabled -> pause
    }

    public static byte[] ReadAllBytes(string fileName)
    {
        string path = Path.Combine(Root, fileName.Replace('/', Path.DirectorySeparatorChar));
        if (!File.Exists(path))
        {
            return null;
        }

        return File.ReadAllBytes(path);
    }

    public static void WriteAllBytes(string fileName, byte[] data)
    {
        string path = Path.Combine(Root, fileName.Replace('/', Path.DirectorySeparatorChar));
        string directory = Path.GetDirectoryName(path);
        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }

        File.WriteAllBytes(path, data);
    }
}
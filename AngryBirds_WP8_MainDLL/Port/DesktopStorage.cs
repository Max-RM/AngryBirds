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
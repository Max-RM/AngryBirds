using System;
using System.IO;

namespace AngryBirds.Port;

internal static class DesktopStorage
{
    private static readonly string Root = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "AngryBirds");

    static DesktopStorage()
    {
        Directory.CreateDirectory(Root);
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

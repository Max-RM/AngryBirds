using System;
using System.IO;
using AngryBirds;
using Microsoft.Xna.Framework;

namespace AngryBirdsDesktop;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        try
        {
            using var game = new GameMain();
            game.Run();
        }
        catch (Exception ex)
        {
            var logPath = Path.Combine(AppContext.BaseDirectory, "AngryBirds-crash.log");
            File.WriteAllText(logPath, ex.ToString());
            throw;
        }
    }
}

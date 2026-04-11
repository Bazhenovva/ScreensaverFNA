using System;
using Microsoft.Xna.Framework;

namespace ScreensaverFNA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new SnowfallGame())
            {
                game.Run();
            }
        }
    }
}

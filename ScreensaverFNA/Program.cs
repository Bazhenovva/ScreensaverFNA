using System;

namespace ScreensaverFNA
{
    /// <summary>
    /// Точка входа в приложение
    /// </summary>
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

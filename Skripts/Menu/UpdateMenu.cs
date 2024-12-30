using IsaacGame.Skripts.Draw;
using IsaacGame.Skripts.UpdateContent;
using System.Diagnostics;

namespace IsaacGame.Skripts.Menu
{
    internal class UpdateMenu
    {
        public static string[] MenuArray = { "New Game  ", "Stats", "Settings", "Exit" };
        public static int Index = -1;

        private static Stopwatch Stopwatch = new();

        public static void IndexChange(int PlusOneOrMinusOne)
        {
            if (Stopwatch.ElapsedMilliseconds > 130 || !Stopwatch.IsRunning)  // Pauza aby se nepřepínalo moc rychle v menu
            {
                Index += PlusOneOrMinusOne;
                Stopwatch.Restart();
            }

            if (Index > MenuArray.Length - 1) Index = 0;
            else if (Index < 0) Index = MenuArray.Length - 1;
        }

        public static void DrawFromMenu(Main main)
        {
            switch (Index)
            {
                case 0: Settings.SettingsThis.NewGame = true;            // new game
                    break;

                case 1: // stats
                    break;

                case 2: // settings
                    break;

                case 3: main.Exit();
                    break;
            }
        }

















    }
}

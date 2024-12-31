using IsaacGame.Skripts.Draw;
using IsaacGame.Skripts.UpdateContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace IsaacGame.Skripts.Menu
{
    internal class Index
    {
        public static string[] MenuArray = { "New Game  ", "Stats", "Settings", "Exit" };
        public static int IndexPosition = -1;

        private static Stopwatch Stopwatch = new();
        private static Vector2 _lastMousePosition;


        public static void IndexChangeKeyboard(int PlusOneOrMinusOne)         // Změna pozice v menu pomocí klavesnice
        {
            if (Stopwatch.ElapsedMilliseconds > 130 || !Stopwatch.IsRunning)  // Pauza aby se nepřepínalo moc rychle v menu
            {
                IndexPosition += PlusOneOrMinusOne;
                Stopwatch.Restart();
            }

            if (IndexPosition > MenuArray.Length - 1) IndexPosition = 0;
            else if (IndexPosition < 0) IndexPosition = MenuArray.Length - 1;
        }



        public static void IndexChangeMouse(Main main)                           // Pri najetí myší na položku v menu ji označí
        {
            if (KeyMapMenu.MousePosition != _lastMousePosition)         // Pokud se nehýbe s mýší, tak nekontroluje stav
            {
                _lastMousePosition = KeyMapMenu.MousePosition;

                for (int i = 0; i < MenuArray.Length; i++)
                    if (new Rectangle(340, i * 100 + 270, 44 * MenuArray[i].Length, 70).Contains(KeyMapMenu.MousePosition)) IndexPosition = i;

            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed) DrawFromMenu(main);
        }


        public static void DrawFromMenu(Main main)
        {
            switch (IndexPosition)
            {
                case 0:
                    Settings.SettingsThis.NewGame = true;            // new game
                    break;

                case 1:                                              // stats
                    break;

                case 2:                                              // settings
                    break;

                case 3:                                              //  Exit
                    main.Exit();
                    break;
            }
        }

















    }
}

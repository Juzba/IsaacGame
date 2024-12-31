using IsaacGame.Skripts.Draw;
using IsaacGame.Skripts.UpdateContent;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace IsaacGame.Skripts.Menu
{
    internal class KeyMapMenu
    {
        public static Stopwatch Stopwatch = new();
        public static Vector2 MousePosition;






        public static void HotKeys(Main main)
        {

            MousePosition = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
            Index.IndexChangeMouse(main);                                                                                       // Při pohybu mýší oznčí položku menu

            var _gamePadState = GamePad.GetState(PlayerIndex.One);
            Vector2 _leftThumbStick = _gamePadState.ThumbSticks.Left;


            if (!Stopwatch.IsRunning)
            {
                if (_gamePadState.Buttons.Start == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))       // Escape
                      { Settings.SettingsThis.OpenMenu = false; Stopwatch.Start(); Index.IndexPosition = -1; }
    
                else if (_leftThumbStick.Y > 0.2f || Keyboard.GetState().IsKeyDown(Keys.W))                                 // W
                     { Index.IndexChangeKeyboard(-1); }

                else if (_leftThumbStick.Y < -0.2f || Keyboard.GetState().IsKeyDown(Keys.S))                                // S
                     { Index.IndexChangeKeyboard(+1); }




                else if (_gamePadState.Buttons.A == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Enter))        // Enter
                     { Index.DrawFromMenu(main); }





            }
            else if (Stopwatch.ElapsedMilliseconds > 500) Stopwatch.Reset();
        }
    }
}

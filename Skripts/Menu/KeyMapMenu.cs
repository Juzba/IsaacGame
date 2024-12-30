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




        public static void HotKeys(Main main)
        {
            var _gamePadState = GamePad.GetState(PlayerIndex.One);
            Vector2 _leftThumbStick = _gamePadState.ThumbSticks.Left;

            if (!Stopwatch.IsRunning)
            {
                if (_gamePadState.Buttons.Start == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))       // Escape
                    { Settings.SettingsThis.OpenMenu = false; Stopwatch.Start(); UpdateMenu.Index = -1; }

                else if (_leftThumbStick.Y > 0.2f || Keyboard.GetState().IsKeyDown(Keys.W))                                 // W
                    { UpdateMenu.IndexChange(-1); }

                else if (_leftThumbStick.Y < -0.2f || Keyboard.GetState().IsKeyDown(Keys.S))                                // S
                    { UpdateMenu.IndexChange(+1); }




                else if(_gamePadState.Buttons.A == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Enter))        // Enter
                {
                    UpdateMenu.DrawFromMenu(main);
                }





            }
            else if (Stopwatch.ElapsedMilliseconds > 500) Stopwatch.Reset();
        }
    }
}

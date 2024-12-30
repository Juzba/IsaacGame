using IsaacGame.Skripts.Draw;
using IsaacGame.Skripts.Menu;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace IsaacGame.Skripts.UpdateContent
{
    internal class KeyMapGame
    {
        public static void HotKeys(Main main)
        {
            if (!KeyMapMenu.Stopwatch.IsRunning)
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Start == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))    // Escape
                { Settings.SettingsThis.OpenMenu = true; KeyMapMenu.Stopwatch.Start(); DrawMenu.Count = 0; }

                //else if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) main.Exit();

            }
            else if (KeyMapMenu.Stopwatch.ElapsedMilliseconds > 500) KeyMapMenu.Stopwatch.Reset();
        }
    }
}

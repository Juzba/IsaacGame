using IsaacGame.Skripts.Draw;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace IsaacGame.Skripts.UpdateContent
{
    internal class KeyMapMenu
    {
        public static Stopwatch Stopwatch = new();


        public static void HotKeys(Main main)
        {
            if (!Stopwatch.IsRunning)
            {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                { Settings.SettingsThis.OpenMenu = false; Stopwatch.Start(); }
                //else if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) main.Exit();




            }
            else if (Stopwatch.ElapsedMilliseconds > 500) Stopwatch.Reset();
        }





    }
}

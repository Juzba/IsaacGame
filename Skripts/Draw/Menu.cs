using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;


namespace IsaacGame.Skripts.Draw;

internal class Menu
{

    private static Texture2D _backGround, _pixel;
    private static SpriteFont _font, _font2;
    private static string[] _menuArray = {"New Game", "Stats", "Settings", "Exit"};


    public static void Content(Main game1)
    {
        _backGround = game1.Content.Load<Texture2D>("Sprites/Menu/MenuBackGround");
        _pixel = game1.Content.Load<Texture2D>("Sprites/Menu/Pixel");
        _font = game1.Content.Load<SpriteFont>("Sprites/Menu/FontMenu");



    }


    public static void Draw(SpriteBatch spriteBatch, Main main)
    {
        var deviceWidth = main.GraphicsDevice.Viewport.Width - 80;
        var deviceHeight = main.GraphicsDevice.Viewport.Height - 80;


        spriteBatch.Draw(_backGround, new Rectangle(40, 40, deviceWidth, deviceHeight), Color.White);

        spriteBatch.Draw(_pixel, new Rectangle(180, 150, 700, _menuArray.Count() * 100 + 200 ), new Color(Color.Black, 128));


        int x = 0;
        foreach (var item in _menuArray)
        {
            spriteBatch.DrawString(_font, item, new Vector2(348, 248 + x), Color.Black, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0.1f);
            spriteBatch.DrawString(_font, item, new Vector2(352, 252 + x), Color.Red, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0.1f);
            spriteBatch.DrawString(_font, item, new Vector2(350, 250 + x), Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0.1f);
            x += 100;
        }


    }


    //private static Texture2D AwesomeMenu(int RanDomSeed, Texture2D texture1, Texture2D texture2, Texture2D texture3)
    //{
    //    Random rnd = new Random(RanDomSeed);
    //    Random rnd2 = new Random(RanDomSeed + 1);

    //    if (rnd.Next(100) > 50) return texture2;
    //    else if (rnd2.Next(100) > 50) return texture3;

    //    return texture1;
    //}







}













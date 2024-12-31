using IsaacGame.Skripts.Draw;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using IsaacGame.Skripts.Menu;
using Microsoft.Xna.Framework.Audio;




namespace IsaacGame.Skripts.Menu;

internal class DrawMenu
{
    public static int Count = 0;
    private static int _lastIndex = Index.IndexPosition;

    private static Texture2D _backGround, _pixel, _backLight;
    private static SpriteFont _font, _fontSmall;
    private static Song _backgroundMusic;
    private static SoundEffect _indexSound;


    



    public static void Content(Main game1)
    {
        _backGround = game1.Content.Load<Texture2D>("Sprites/Menu/MenuBackGround");
        _backLight = game1.Content.Load<Texture2D>("Sprites/Menu/BacklightRed");
        _pixel = game1.Content.Load<Texture2D>("Sprites/Menu/Pixel");
        _font = game1.Content.Load<SpriteFont>("Sprites/Menu/FontMenu");
        _fontSmall = game1.Content.Load<SpriteFont>("Sprites/Menu/Font50");
        _backgroundMusic = game1.Content.Load<Song>("Sprites/Menu/Main");
        _indexSound = game1.Content.Load<SoundEffect>("Sprites/Menu/pick2");

        
    }


    public static void Draw(SpriteBatch spriteBatch, Main main, GameTime gameTime)
    {
        var deviceWidth = main.GraphicsDevice.Viewport.Width - 80;
        var deviceHeight = main.GraphicsDevice.Viewport.Height - 80;
        main.GraphicsDevice.BlendState = BlendState.AlphaBlend;

        if (Count == 0) MediaPlayer.Play(_backgroundMusic, new TimeSpan(0, 0, 6));                                // BackGround music
        if(Index.IndexPosition != _lastIndex) { _lastIndex = Index.IndexPosition; _indexSound.Play(0.4f, 0f, 0f); }           // Index sound if Changed


        

        spriteBatch.Draw(_backGround, new Rectangle(40, 40, deviceWidth, deviceHeight), Color.White);

        spriteBatch.Draw(_pixel, new Rectangle(180, 150, Effects.OpenEffect(800,Count), Effects.OpenEffect(Index.MenuArray.Length * 100 + 200, Count)), new Color(Color.Black, 128));


        float size;
        int gap = 0;
        if (Count > 8)
            for (int i = 0; i < Index.MenuArray.Length; i++)
            {
                if (i == Index.IndexPosition)
                {
                    size = 0.2f;
                    spriteBatch.Draw(_backLight, new Rectangle(305, 270 + gap, Index.MenuArray[i].Length * 67, 100), new Color(Color.White, Effects.FadeEffect()));   // Označené pole menu
                }
                else size = 0f;

                spriteBatch.DrawString(_font, Index.MenuArray[i], new Vector2(348 + Effects.TicEffect(), 248 + gap + Effects.TicEffect()), Color.Black, 0f, Vector2.Zero, 0.7f + size, SpriteEffects.None, 0.1f);
                spriteBatch.DrawString(_font, Index.MenuArray[i], new Vector2(352 + Effects.TicEffect(), 252 + gap + Effects.TicEffect()), Color.Red, 0f, Vector2.Zero, 0.7f + size, SpriteEffects.None, 0.1f);
                spriteBatch.DrawString(_font, Index.MenuArray[i], new Vector2(350 + Effects.TicEffect(), 250 + gap + Effects.TicEffect()), Color.White, 0f, Vector2.Zero, 0.7f + size, SpriteEffects.None, 0.1f);
                gap += 100;
            }

        spriteBatch.DrawString(_fontSmall, KeyMapMenu.MousePosition.ToString() , new Vector2(1400, 50), Color.Azure);                                        // Aktualní pozice myši
        spriteBatch.DrawString(_fontSmall, Effects.FPS(Count, gameTime.TotalGameTime.TotalMilliseconds) + " fps", new Vector2(1400, 120), Color.Azure);      // Zobrazí FPS
        
        Count++;
    }
}













using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using IsaacGame.Skripts.UpdateContent;
using IsaacGame.Skripts.Menu;


namespace IsaacGame.Skripts.Draw;


public class Main : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    

    public Main()
    {
        _graphics = new GraphicsDeviceManager(this);
        _graphics.PreferredBackBufferWidth = 1920;
        _graphics.PreferredBackBufferHeight = 1080;
        //_graphics.IsFullScreen = true;
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        DrawMenu.Content(this);

    }

    protected override void Update(GameTime gameTime)
    {
        if(!Settings.SettingsThis.OpenMenu) KeyMapGame.HotKeys(this);         // Game
        else KeyMapMenu.HotKeys(this);                                        // Menu

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);
        _spriteBatch.Begin();


        if(Settings.SettingsThis.OpenMenu) DrawMenu.Draw(_spriteBatch, this, gameTime);






        _spriteBatch.End();
        base.Draw(gameTime);
    }
}

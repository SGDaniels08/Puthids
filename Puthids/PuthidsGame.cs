using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Puthids
{
    public class PuthidsGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GameContent _gameContent;
        private MouseState _oldMouseState;
        private KeyboardState _oldKeyboardState;

        private int _screenWidth = 0;
        private int _screenHeight = 0;

        private Puthid _mainCharacter;
        private List<Puthid> _colony;
        private Terrarium _terrarium;
        private List<Terrarium> TheWall;

        public PuthidsGame()
        {
            _graphics = new GraphicsDeviceManager(this);
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

            // TODO: use this.Content to load your game content here
            _gameContent = new GameContent(Content);
            _screenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            _screenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            // set game to 502 x 700 or screen max if smaller
            if (_screenWidth >= 502)
            {
                _screenWidth = 502;
            }
            if (_screenHeight >= 700)
            {
                _screenHeight = 700;
            }
            _graphics.PreferredBackBufferWidth = _screenWidth;
            _graphics.PreferredBackBufferHeight = _screenHeight;
            _graphics.ApplyChanges();

            // create game objects

        }

        protected override void Update(GameTime gameTime)
        {
            if (IsActive == false)
            {
                return; // our window is not active don't update
            }

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            KeyboardState newKeyboardState = Keyboard.GetState();
            MouseState newMouseState = Mouse.GetState();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

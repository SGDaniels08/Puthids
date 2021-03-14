using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Puthids.Entities;
using MonoGame;

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

        // TEST OBJECTS //
        private VWall vWall;

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
            // set game to 1000 x 500 or screen max if smaller
            if (_screenWidth >= 1000)
            {
                _screenWidth = 1000;
            }
            if (_screenHeight >= 500)
            {
                _screenHeight = 500;
            }
            _graphics.PreferredBackBufferWidth = _screenWidth;
            _graphics.PreferredBackBufferHeight = _screenHeight;
            _graphics.ApplyChanges();

            // create game objects
            _mainCharacter = new Puthid(10, 10, _screenWidth, _screenHeight, _spriteBatch, _gameContent);
            //vWall = new VWall(100, 100, 10, 100, _spriteBatch);
            _terrarium = new Terrarium(100, 100, 500, 125, 5, _spriteBatch);
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

            // process keyboard events
            if (newKeyboardState.IsKeyDown(Keys.Left))
            {
                _mainCharacter.MoveLeft();
            }
            if (newKeyboardState.IsKeyDown(Keys.Right))
            {
                _mainCharacter.MoveRight();
            }
            if (newKeyboardState.IsKeyDown(Keys.Up))
            {
                _mainCharacter.MoveUp();
            }
            if (newKeyboardState.IsKeyDown(Keys.Down))
            {
                _mainCharacter.MoveDown();
            }

            _oldMouseState = newMouseState;
            _oldKeyboardState = newKeyboardState;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _terrarium.Draw();
            //vWall.Draw();
            _mainCharacter.Draw();
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

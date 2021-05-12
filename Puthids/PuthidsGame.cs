using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Puthids.Entities;
using MonoGame;
using Puthids.Entities.Terrain;
using Puthids.Entities.Critters;

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
        private double elapsedTime = 0;

        private PlayerPuthid _mainCharacter;
        private List<NPCPuthid> _colony;
        private Terrarium _terr1;
        private Terrarium _terr2;
        private List<Terrarium> TheWall;
        private House _house;


        private const double MILLISECONDS_2000 = 2000;
        private const double MILLISECONDS_3000 = 3000;
        private const double MILLISECONDS_5000 = 5000;

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
            if (_screenWidth >= 2000)
            {
                _screenWidth = 2000;
            }
            if (_screenHeight >= 500)
            {
                _screenHeight = 500;
            }
            _graphics.PreferredBackBufferWidth = _screenWidth;
            _graphics.PreferredBackBufferHeight = _screenHeight;
            _graphics.ApplyChanges();

            // create game objects
            _mainCharacter = new PlayerPuthid(100, 100, _spriteBatch, _gameContent);

            // Build out terrarium
            _terr1 = new Terrarium(10, 10, 800, 450, 25, _spriteBatch); // refactor to: new Terrarium(x, y, airGrid, groundGrid, _spriteBatch);
            //_terr2 = new Terrarium(1200, 10, 300, 450, 10, _spriteBatch);
            _colony = new List<NPCPuthid>
            {
                new NPCPuthid(500, 130, _spriteBatch, _gameContent)
            };

            _house = new House(40, 75, _spriteBatch, _gameContent);
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
                _mainCharacter.MoveLeft(_terr1);
            }
            if (newKeyboardState.IsKeyDown(Keys.Right))
            {
                _mainCharacter.MoveRight(_terr1);
            }
            if (newKeyboardState.IsKeyDown(Keys.Up))
            {
                _mainCharacter.MoveUp(_terr1);
            }
            if (newKeyboardState.IsKeyDown(Keys.Down))
            {
                _mainCharacter.MoveDown(_terr1);
            }

            // process mouse events
            if (_oldMouseState.LeftButton == ButtonState.Pressed && newMouseState.LeftButton == ButtonState.Released)
            {
                _house.IsSelected = false;
                if (_house.Rect.Contains(newMouseState.Position))
                {
                    _house.IsSelected = true;
                    _colony.Add(_house.SpawnPuthid());
                }

                foreach (ATerrain block in _terr1.Terrain.TGrid)
                {
                    block.IsSelected = false;
                    if (block.TRect.Contains(newMouseState.Position))
                    {
                        _mainCharacter.Select(block);
                    }
                }
            }

            _oldMouseState = newMouseState;
            _oldKeyboardState = newKeyboardState;

            // NPC Actions
            // every five seconds, either stop or change direction
            elapsedTime += gameTime.ElapsedGameTime.TotalMilliseconds;
            if (elapsedTime >= MILLISECONDS_2000)
            {
                foreach (NPCPuthid npc in _colony)
                {
                    npc.DetermineAction();
                }
                elapsedTime = 0;
            }

            foreach (NPCPuthid npc in _colony)
            {
                npc.Act(_terr1);
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _terr1.Draw();
            //_terr2.Draw();
            _house.Draw();

            foreach (NPCPuthid npc in _colony)
            {
                npc.Draw();
            }
            _mainCharacter.Draw();
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Puthids.Entities.Critters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities
{
    public class House
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Texture2D Image { get; set; }
        public List<APuthid> Inhabitants { get; set; }       // Potential inhabitants

        private SpriteBatch _spriteBatch;    // allows us to write on backbuffer when we need to draw self
        private GameContent _gameContent;

        public House(float x, float y, SpriteBatch spriteBatch, GameContent gameContent)
        {
            X = x; Y = y; _spriteBatch = spriteBatch; _gameContent = gameContent;
            Image = _gameContent.ImgHouse;
        }

        public void Draw()
        {
            SpriteEffects spriteEffects = SpriteEffects.None;
            _spriteBatch.Draw(Image, new Vector2(X, Y), null, Color.White, 0, new Vector2(0, 0), 1.0f, spriteEffects, 0);
        }

        public APuthid SpawnPuthid()
        {
            NPCPuthid temp = new NPCPuthid(200, 135, _spriteBatch, _gameContent);
            // add to _colony
            return temp;
        }
    }
}

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities.Critters
{
    public class NPCPuthid : APuthid
    {
        public Brain AutomationEngine { get; set; }

        private Texture2D imgPuthid { get; set; }   // current image of Puthid
        private SpriteBatch _spriteBatch;    // allows us to write on backbuffer when we need to draw self
        private GameContent _gameContent;
        private int FrameIndex
        { get; set; }
        public NPCPuthid(float x, float y, SpriteBatch spriteBatch, GameContent gameContent) : base(x, y, spriteBatch, gameContent)
        {

        }

        public void Autonomize(GameTime gameTime)
        {
            AutomationEngine.Autonomize();
        }
    }
}

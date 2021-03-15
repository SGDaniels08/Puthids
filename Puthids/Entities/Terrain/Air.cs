using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities.Terrain
{
    public class Air : ATerrain
    {
        public Air(int x, int y, int length, int height, SpriteBatch spriteBatch) : base(x, y, length, height, spriteBatch)
        {
            this.BlockColor = Color.Transparent;
        }
        public override void Draw()
        {
            _spriteBatch.FillRectangle(TRect, this.BlockColor);
        }
    }
}

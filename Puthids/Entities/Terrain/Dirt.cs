using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using MonoGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities.Terrain
{
    public class Dirt : ATerrain, IImpermeable
    {
        // Statuses
        public bool IsTilled { get; set; }
        public bool IsPlanted { get; set; }

        public Dirt(int x, int y, SpriteBatch spriteBatch) : base (x, y, spriteBatch)
        {

            this.BlockColor = Color.Brown;
        }
        public override void Draw()
        {
            this.BlockColor = this.IsSelected ? Color.Green : Color.Brown;
            _spriteBatch.FillRectangle(TRect, this.BlockColor);
        }
    }
}

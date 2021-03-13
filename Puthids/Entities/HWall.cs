using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities
{
    public class HWall : Wall
    {
        public Rectangle WallRect { get; set; }

        public HWall(float x, float y, float thickness, float length, SpriteBatch spriteBatch) : base(x, y, thickness, length, spriteBatch)
        {
            WallRect = new Rectangle((int)x, (int)y, (int)length, (int)thickness);
        }

        public override void Draw()
        {
            spriteBatch.FillRectangle(WallRect, Color.Chocolate);

        }

    }
}

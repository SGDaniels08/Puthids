using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;
using System;
using System.Collections.Generic;
using System.Text;


namespace Puthids.Entities
{
    public class VWall : Wall
    {
        public Rectangle WallRect { get; set; }

        public VWall(float x, float y, float thickness, float length, SpriteBatch spriteBatch) : base(x, y, thickness, length, spriteBatch)
        {
            WallRect = new Rectangle((int)x, (int)y, (int)thickness, (int)length);
        }

        public override void Draw()
        {
            //FillRectangle Examples
            spriteBatch.FillRectangle(WallRect, Color.LightBlue);
        }
    }
}

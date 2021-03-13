using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;

namespace Puthids.Entities
{
    public abstract class Wall
    {
        public float X { get; set; }    // x position of wall (top-left corner)
        public float Y { get; set; }    // y position of wall (top-left corner)
        public float Thickness { get; set; }    // thickness of wall
        public float Length { get; set; }   // length of wall
        public float Orientation { get; set; } // angle of orientation
        protected SpriteBatch spriteBatch;    // allows us to write on backbuffer when we need to draw self

        public Wall(float x, float y, float thickness, float length, SpriteBatch spriteBatch)
        {
            X = x;
            Y = y;
            Thickness = thickness;
            Length = length;
            this.spriteBatch = spriteBatch;
        }

        public virtual void Draw() { }


    }
}
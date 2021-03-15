using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Puthids.Entities
{
    // A single block in the Terrain Grid
    public abstract class ATerrain
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Rectangle TRect { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        public Color BlockColor { get; set; }
        protected SpriteBatch _spriteBatch;

        public ATerrain(int x, int y, int length, int height, SpriteBatch spriteBatch)
        {
            this.X = x; this.Y = y; this.Length = length; this.Height = height; this._spriteBatch = spriteBatch;
            this.TRect = new Rectangle(x, y, length, height);
        }

        public abstract void Draw();
    }
}
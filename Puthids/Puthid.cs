using Microsoft.Xna.Framework.Graphics;

namespace Puthids
{
    public class Puthid
    {
        public float X { get; set; }    // x position of Puthid (top-left corner)
        public float Y { get; set; }    // y position of Puthid (top-left corner)
        public float Width { get; set; }    // width of Puthid
        public float Height { get; set; }   // height of Puthid

        private Texture2D imgPuthid { get; set; }   // current image of Puthid
        private SpriteBatch spriteBatch;    // allows us to write on backbuffer when we need to draw self

        public Puthid(float x, float y, SpriteBatch spriteBatch, GameContent gameContent)
        {
            X = x;
            Y = y;
            imgPuthid = gameContent.ImgPuthid;
            Width = imgPuthid.Width;
            Height = imgPuthid.Height;
            this.spriteBatch = spriteBatch;
        }

    }
}
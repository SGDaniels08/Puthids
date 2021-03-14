using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Puthids.Entities
{
    public class Puthid
    {
        public float X { get; set; }    // x position of Puthid (top-left corner)
        public float Y { get; set; }    // y position of Puthid (top-left corner)
        public float Width { get; set; }    // width of Puthid
        public float Height { get; set; }   // height of Puthid
        public float ScreenWidth { get; set; }  // width of screen
        public float ScreenHeight { get; set; } // height of screen
        public float MovementSpeed { get; set; } // movement speed per frame of puthid
        private Texture2D imgPuthid { get; set; }   // current image of Puthid
        private SpriteBatch spriteBatch;    // allows us to write on backbuffer when we need to draw self
        private int frameIndex = 0;

        public Puthid(float x, float y, float screenWidth, float screenHeight, SpriteBatch spriteBatch, GameContent gameContent)
        {
            X = x;
            Y = y;
            // Might need to take it from a List<>
            imgPuthid = gameContent.WalkingAnimation[frameIndex];
            Width = imgPuthid.Width;
            Height = imgPuthid.Height;
            this.spriteBatch = spriteBatch;
            ScreenWidth = screenWidth;
            MovementSpeed = 3;
        }

        public void Draw()
        {
            spriteBatch.Draw(imgPuthid, new Vector2(X, Y), null, Color.White, 0, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
        }

        public void MoveLeft(Terrarium terr)
        {
            float oldX = X;
            float oldY = Y;

            X = X - MovementSpeed;
            Rectangle charRect = new Rectangle((int)X, (int)Y, (int)Width, (int)Height);
            if (charRect.Intersects(terr.LeftWall.WallRect) || charRect.Intersects(terr.RightWall.WallRect)
               || charRect.Intersects(terr.TopWall.WallRect) || charRect.Intersects(terr.BottomWall.WallRect))
            {
                X = oldX;
                Y = oldY;
            }
            else if (X < 1)
            {
                X = 1;
            }
        }

        public void MoveRight(Terrarium terr)
        {
            float oldX = X;
            float oldY = Y;
            X = X + MovementSpeed;
            Rectangle charRect = new Rectangle((int)X, (int)Y, (int)Width, (int)Height);
            if (charRect.Intersects(terr.LeftWall.WallRect) || charRect.Intersects(terr.RightWall.WallRect)
               || charRect.Intersects(terr.TopWall.WallRect) || charRect.Intersects(terr.BottomWall.WallRect))
            {
                X = oldX;
                Y = oldY;
            }
        }

        public void MoveUp(Terrarium terr)
        {
            float oldX = X;
            float oldY = Y;
            Y = Y - MovementSpeed;
            Rectangle charRect = new Rectangle((int)X, (int)Y, (int)Width, (int)Height);
            if (charRect.Intersects(terr.LeftWall.WallRect) || charRect.Intersects(terr.RightWall.WallRect)
               || charRect.Intersects(terr.TopWall.WallRect) || charRect.Intersects(terr.BottomWall.WallRect))
            {
                X = oldX;
                Y = oldY;
            }
            if (Y < 1)
            {
                Y = 1;
            }
        }

        public void MoveDown(Terrarium terr)
        {
            float oldX = X;
            float oldY = Y;
            Y = Y + MovementSpeed;
            Rectangle charRect = new Rectangle((int)X, (int)Y, (int)Width, (int)Height);
            if (charRect.Intersects(terr.LeftWall.WallRect) || charRect.Intersects(terr.RightWall.WallRect)
               || charRect.Intersects(terr.TopWall.WallRect) || charRect.Intersects(terr.BottomWall.WallRect))
            {
                X = oldX;
                Y = oldY;
            }
        }

        public void MoveTo(float x)
        {
            if (x >= 0)
            {
                if (x < ScreenWidth - Width)
                {
                    X = x;
                }
                else
                {
                    X = ScreenWidth - Width;
                }
            }
            else
            {
                if (x < 0)
                {
                    X = 0;
                }
            }
        }
    }
}
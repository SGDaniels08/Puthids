using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Puthids.Entities
{
    public class PlayerPuthid : APuthid
    {
        private Texture2D imgPuthid { get; set; }   // current image of Puthid
        private SpriteBatch _spriteBatch;    // allows us to write on backbuffer when we need to draw self
        private GameContent _gameContent;   
        private int FrameIndex 
        { get; set; }

        public PlayerPuthid(float x, float y, SpriteBatch spriteBatch, GameContent gameContent) : base(x,y,spriteBatch, gameContent)
        {
        }

        //public override void Draw()
        //{
        //    SpriteEffects spriteEffects = SpriteEffects.None;
        //    if (this.FacingDirection == Direction.RIGHT)
        //        spriteEffects = SpriteEffects.None;
        //    else if (this.FacingDirection == Direction.LEFT)
        //        spriteEffects = SpriteEffects.FlipHorizontally;
        //    if (FrameIndex > 23) FrameIndex = 0;
        //    imgPuthid = _gameContent.WalkingAnimation[FrameIndex];
        //    _spriteBatch.Draw(imgPuthid, new Vector2(X, Y), null, Color.White, 0, new Vector2(0, 0), 1.0f, spriteEffects, 0);
        //}

        /* MOVEMENT */
        //public override void MoveLeft(Terrarium terr)
        //{
        //    FrameIndex++;
        //    float oldX = X;
        //    float oldY = Y;
        //    FacingDirection = Direction.LEFT;

        //    X = X - MovementSpeed;
        //    Rectangle charRect = new Rectangle((int)X, (int)Y, (int)Width, (int)Height);
        //    if (charRect.Intersects(terr.LeftWall.WallRect) || charRect.Intersects(terr.RightWall.WallRect)
        //       || charRect.Intersects(terr.TopWall.WallRect) || charRect.Intersects(terr.BottomWall.WallRect))
        //    {
        //        X = oldX;
        //        Y = oldY;
        //    }
        //    foreach (ATerrain block in terr.Terrain.TGrid)
        //    {
        //        if (charRect.Intersects(block.TRect))
        //        {
        //            X = oldX;
        //            Y = oldY;
        //        }
        //    }
        //}

        //public override void MoveRight(Terrarium terr)
        //{
        //    FrameIndex++;

        //    float oldX = X;
        //    float oldY = Y;
        //    FacingDirection = Direction.RIGHT;

        //    X = X + MovementSpeed;
        //    Rectangle charRect = new Rectangle((int)X, (int)Y, (int)Width, (int)Height);
        //    if (charRect.Intersects(terr.LeftWall.WallRect) || charRect.Intersects(terr.RightWall.WallRect)
        //       || charRect.Intersects(terr.TopWall.WallRect) || charRect.Intersects(terr.BottomWall.WallRect))
        //    {
        //        X = oldX;
        //        Y = oldY;
        //    }
        //    foreach (ATerrain block in terr.Terrain.TGrid)
        //    {
        //        if (charRect.Intersects(block.TRect))
        //        {
        //            X = oldX;
        //            Y = oldY;
        //        }
        //    }
        //}

        //public void MoveUp(Terrarium terr)
        //{
        //    FrameIndex++;

        //    float oldX = X;
        //    float oldY = Y;
        //    Y = Y - MovementSpeed;
        //    Rectangle charRect = new Rectangle((int)X, (int)Y, (int)Width, (int)Height);
        //    if (charRect.Intersects(terr.LeftWall.WallRect) || charRect.Intersects(terr.RightWall.WallRect)
        //       || charRect.Intersects(terr.TopWall.WallRect) || charRect.Intersects(terr.BottomWall.WallRect))
        //    {
        //        X = oldX;
        //        Y = oldY;
        //    }
        //    foreach (ATerrain block in terr.Terrain.TGrid)
        //    {
        //        if (charRect.Intersects(block.TRect))
        //        {
        //            X = oldX;
        //            Y = oldY;
        //        }
        //    }
        //}

        //public override void MoveDown(Terrarium terr)
        //{
        //    FrameIndex++;

        //    float oldX = X;
        //    float oldY = Y;
        //    Y = Y + MovementSpeed;
        //    Rectangle charRect = new Rectangle((int)X, (int)Y, (int)Width, (int)Height);
        //    if (charRect.Intersects(terr.LeftWall.WallRect) || charRect.Intersects(terr.RightWall.WallRect)
        //       || charRect.Intersects(terr.TopWall.WallRect) || charRect.Intersects(terr.BottomWall.WallRect))
        //    {
        //        X = oldX;
        //        Y = oldY;
        //    }
        //    foreach (ATerrain block in terr.Terrain.TGrid)
        //    {
        //        if (charRect.Intersects(block.TRect))
        //        {
        //            X = oldX;
        //            Y = oldY;
        //        }
        //    }
        //}

        //public void MoveTo(float x, float y)
        //{
            
        //}

        /* Other actions */




        public PlayerPuthid Reproduce(PlayerPuthid mate)
        {
            PlayerPuthid offspring = new PlayerPuthid(0, 0, _spriteBatch, _gameContent);

            return offspring;
        }
    }
}
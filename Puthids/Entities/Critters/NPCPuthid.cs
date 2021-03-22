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

        public void DetermineAction()
        {
            Random random = new Random();
            int choice = random.Next(1, 4);
            switch (choice)
            {
                case 1:
                    FacingDirection = Direction.LEFT;
                    break;
                case 2:
                    FacingDirection = Direction.RIGHT;
                    break;
                case 3:
                    FacingDirection = Direction.FORWARD;
                    break;
            }
        }

        internal void Act(Terrarium terr)
        {
            switch (FacingDirection)
            {
                case Direction.LEFT:
                    this.MoveLeft(terr);
                    break;
                case Direction.RIGHT:
                    this.MoveRight(terr);
                    break;
                case Direction.FORWARD:
                    this.FaceForward(terr);
                    break;
            }
        }
    }
}

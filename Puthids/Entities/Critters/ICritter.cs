using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities
{
    public interface ICritter
    {
        public float X { get; set; }    // x position of critter (top-left corner)
        public float Y { get; set; }    // y position of critter (top-left corner)
        public float Width { get; set; }    // width of critter
        public float Height { get; set; }   // height of critter
        public float MovementSpeed { get; set; } // movement speed per frame of critter
        public string FacingDirection { get; set; } // Direction in which the critter is facing

        public void Draw();

        /* MOVEMENT */
        public void MoveLeft(Terrarium terr);
        public void MoveRight(Terrarium terr);
        public void MoveUp(Terrarium terr);
        public void MoveDown(Terrarium terr);

        public void MoveTo(float x, float y);

        /* Other actions */
        public void Select(ATerrain block);



        public abstract ICritter Reproduce(ICritter mate);
    }
}

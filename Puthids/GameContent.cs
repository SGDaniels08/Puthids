using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids
{
    public class GameContent
    {
        public Texture2D ImgPuthid { get; set; }
        public Texture2D ImgHouse { get; set; }
        public List<Texture2D> WalkingAnimation { get; set; }
        public Texture2D FacingForward { get; set; }
        public SoundEffect Bonk { get; set; }
        public SpriteFont GameFont { get; set; }

        public GameContent(ContentManager Content)
        {
            ImgHouse = Content.Load<Texture2D>("House");
            WalkingAnimation = new List<Texture2D>();
            Texture2D temp;
            // load images
            for (int i = 0; i < 24; i++)
            {
                temp = Content.Load<Texture2D>($"puthid_walking{i}");
                
                WalkingAnimation.Add(temp);
            }
            FacingForward = Content.Load<Texture2D>("stickperson__wave0");

            // load sounds

            // load fonts
        }

    }
}

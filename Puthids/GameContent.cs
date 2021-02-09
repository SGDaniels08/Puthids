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
        public List<Texture2D> WalkingAnimation { get; set; }
        public SoundEffect Bonk { get; set; }
        public SpriteFont GameFont { get; set; }

        public GameContent(ContentManager Content)
        {
            // load images

            // load sounds

            // load fonts
        }

    }
}

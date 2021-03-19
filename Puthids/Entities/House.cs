using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities
{
    public class House
    {
        public Texture2D Image { get; set; }
        public List<Puthid> Inhabitants { get; set; }       // Potential inhabitants
    }
}

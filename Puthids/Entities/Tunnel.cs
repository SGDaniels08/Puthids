using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities
{
    public class Tunnel
    {
        public Wall ConnectWallA { get; set; }
        public Wall ConnectWallB { get; set; }
        public float Height { get; set; }
    }
}

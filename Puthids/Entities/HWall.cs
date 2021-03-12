using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities
{
    public class HWall : Wall
    {
        public HWall(float x, float y, float thickness, float length) : base(x, y, thickness, length, 90)
        {

        }
    }
}

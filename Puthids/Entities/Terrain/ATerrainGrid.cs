using Microsoft.Xna.Framework.Graphics;
using Puthids.Entities.Terrain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities
{
    public abstract class ATerrainGrid
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        // [rows, columns]
        public ATerrain[,] TGrid { get; set; }

        public void Draw()
        {
            foreach (ATerrain block in TGrid)
            {
                block.Draw();
            }
        }
    }
}

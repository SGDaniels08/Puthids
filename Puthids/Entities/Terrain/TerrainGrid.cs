using Microsoft.Xna.Framework.Graphics;
using Puthids.Entities.Terrain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities
{
    public class TerrainGrid
    {
        public float X { get; set; }
        public float Y { get; set; }
        // [rows, columns]
        public ATerrain[,] TGrid { get; set; }

        public TerrainGrid (float x, float y, int columns, int rows, SpriteBatch spriteBatch)
        {
            X = x; Y = y;
            TGrid = new ATerrain[columns, rows];
            int tempX = (int)X;
            // Start with one column...
            for (int i = 0; i < columns; i++)
            {
                int tempY = (int)Y;

                // Add a block for each row in that column
                for (int j = 0; j < rows; j++)
                {
                    TGrid[i, j] = new Dirt(tempX, tempY, 35, 50, spriteBatch);
                    tempY += 55;
                }
                // Repeat with the next column
                tempX += 40;
            }
        }

        internal void Draw()
        {
            foreach (ATerrain block in TGrid)
            {
                block.Draw();
            }
        }
    }
}

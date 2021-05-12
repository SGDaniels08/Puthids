using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities.Terrain
{
    public class GroundGrid : ATerrainGrid
    {
        public GroundGrid(float x, float y, int columns, int rows, SpriteBatch spriteBatch)
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
                    TGrid[i, j] = new Dirt(tempX, tempY, spriteBatch);
                    tempY += Height;
                }
                // Repeat with the next column
                tempX += Length;
            }
        }
    }
}

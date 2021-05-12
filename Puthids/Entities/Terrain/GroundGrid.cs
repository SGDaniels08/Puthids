using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puthids.Entities.Terrain
{
    public class GroundGrid : ATerrainGrid
    {
        public GroundGrid(float x, float y, int columns, int rows, SpriteBatch spriteBatch) : base (x, y, columns, rows, spriteBatch)
        {

            float tempX = X;
            // Start with one column...
            for (int i = 0; i < Columns; i++)
            {
                float tempY = Y;

                // Add a block for each row in that column
                for (int j = 0; j < Rows; j++)
                {
                    TGrid[i, j] = new Dirt((int)tempX, (int)tempY, spriteBatch);
                    tempY += ATerrain.Height;
                }
                // Repeat with the next column
                tempX += ATerrain.Width;
            }
        }
    }
}

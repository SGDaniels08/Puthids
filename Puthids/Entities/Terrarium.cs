using Microsoft.Xna.Framework.Graphics;
using Puthids.Entities.Terrain;

namespace Puthids.Entities
{
    public class Terrarium
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        public float WallThickness { get; set; }
        public HWall TopWall { get; set; }
        public HWall BottomWall { get; set; }
        public VWall LeftWall { get; set; }
        public VWall RightWall { get; set; }
        public ATerrainGrid Terrain { get; set; }
        private SpriteBatch _spriteBatch;

        public Terrarium (float x, float y, float length, float height, float thickness, SpriteBatch spriteBatch)
        {
            X = x; Y = y; Length = length; Height = height; WallThickness = thickness;
            _spriteBatch = spriteBatch;
            TopWall = new HWall(X, Y, WallThickness, Length, _spriteBatch);
            BottomWall = new HWall(X, Y + Height - WallThickness, WallThickness, Length, _spriteBatch);
            LeftWall = new VWall(X, Y, WallThickness, Height, _spriteBatch);
            RightWall = new VWall(X + Length, Y, WallThickness, Height, _spriteBatch);

            // Calculate dimensions
            float terrainStartX = (X + WallThickness);
            float terrainStartY = 215;
            int columns = 19;
            int rows = 4;
            Terrain = new GroundGrid(terrainStartX, terrainStartY, columns, rows, _spriteBatch);
        }

        public void Draw()
        {
            TopWall.Draw();
            BottomWall.Draw();
            LeftWall.Draw();
            RightWall.Draw();
            Terrain.Draw();
        }
    }
}
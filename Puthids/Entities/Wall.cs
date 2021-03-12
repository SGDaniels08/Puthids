namespace Puthids.Entities
{
    public abstract class Wall
    {
        public float X { get; set; }    // x position of wall (top-left corner)
        public float Y { get; set; }    // y position of wall (top-left corner)
        public float Thickness { get; set; }    // thickness of wall
        public float Length { get; set; }   // length of wall
        public float Orientation { get; set; } // angle of orientation

        public Wall(float x, float y, float thickness, float length, float orientation)
        {

        }
    }
}
namespace Puthids.Entities
{
    public class Terrarium
    {
        public HWall TopWall { get; set; }
        public HWall BottomWall { get; set; }
        public VWall LeftWall { get; set; }
        public VWall RightWall { get; set; }

        public Terrarium (HWall top, HWall bot, VWall left, VWall right)
        {

        }
    }
}
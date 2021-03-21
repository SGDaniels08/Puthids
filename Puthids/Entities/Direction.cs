using System;

namespace Puthids.Entities
{
    public static class Direction
    {
        public const string LEFT = "left";
        public const string RIGHT = "right";
        public const string FORWARD = "forward";
        public const string BACK = "back";
        public const string UP = "up";
        public const string DOWN = "down";

        public static string RandomDirection()
        {
            Random random = new Random();
            int randomChoice = random.Next(0, 2);
            switch (randomChoice)
            {
                case 0:
                    return LEFT;
                case 1:
                    return RIGHT;
                case 2:
                    return FORWARD;
                default:
                    return RIGHT;
            }
        }
    }
}
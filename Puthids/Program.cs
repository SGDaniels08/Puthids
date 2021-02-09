using System;

namespace Puthids
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new PuthidsGame())
                game.Run();
        }
    }
}

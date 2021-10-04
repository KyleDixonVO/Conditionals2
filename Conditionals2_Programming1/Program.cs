using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2_Programming1
{
    class Program
    {
        static int score = 0;
        static int lives = 3; //lives remaining
        static bool alive = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals 2:");

            lives = lives - 1;
            if (lives < 0)
            {
                lives = 0; //Range check so hud doesn't show -1
                alive = false;
            }

            if (lives == 0)
            {
                alive = false;
            }
            Console.ReadKey(true);
        }
    }
}

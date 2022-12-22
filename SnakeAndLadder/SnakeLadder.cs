using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeLadder
    {
        public static void StartGame()
        {
            //UC1 - single player at start position 0
            int position = 0;
            Console.WriteLine("Player is at {0} position.", position);
            //UC2 - The Player rolls the die to get a number between 1 to 6.
            Random random = new Random();
            int die = random.Next(1, 7);
            position = position + die;
            Console.WriteLine("You Got : " + die);
            Console.WriteLine("Player position at : "+position);
        }
    }
}

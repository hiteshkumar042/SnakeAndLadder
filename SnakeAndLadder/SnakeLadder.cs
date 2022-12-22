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
            int position = 0, die, dieCount = 0;
            Console.WriteLine("Player is at {0} position.", position);
            Random random = new Random();
            
            //UC4 - Repeat till Position 100
            while (position < 100)
            {
                //UC2 - The Player rolls the die to get a number between 1 to 6.
                die = random.Next(1, 7);
                //UC3 - Adding option for Ladder, Snake and No Play
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0: //snake
                        Console.WriteLine("It's a Snake with {0} points", die);
                        position = position - die; //move behind by points
                        if (position < 0)
                        {
                            position = 0;
                        }
                        //UC6 -  Counting the die roll
                        dieCount++;
                        break;
                    case 1: //ladder
                        Console.WriteLine("It's a Ladder with {0} points", die);
                        position = position + die; //move ahead by points
                        //UC5 - Ensure the player gets exact winning position 100.
                        if (position > 100)
                        {
                            position = position - die;
                        }
                        else if (position == 100)
                        {
                            Console.WriteLine("Player Won!");
                        }
                        //UC6 - Counting the die roll 
                        dieCount++;
                        break;
                    default: //No Play
                        Console.WriteLine("It's a no Play, No Points");
                        position = position + 0;
                        break;
                }
                Console.WriteLine("Player is at {0} position.", position);
            }
            Console.WriteLine("Die rolled for {0} times.", dieCount);
            
        }
    }
}

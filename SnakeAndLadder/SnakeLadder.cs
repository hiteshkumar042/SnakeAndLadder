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
            int die, count = 2;
            int dieCount1 = 0, dieCount2 = 0;
            int pOnePos = 0, pTwoPos = 0;

            //UC7 - Two Players
            Console.Write("Enter 1st Player Name : ");
            string playerOne = Console.ReadLine();
            Console.Write("Enter 2nd Player Name : ");
            string playerTwo = Console.ReadLine();

            Console.WriteLine("Player is at {0} position.", pOnePos);
            Console.WriteLine("Player is at {0} position.", pTwoPos);
            Random random = new Random();
            
            //UC4 - Repeat till Position 100
            while (pOnePos < 100 && pTwoPos < 100)
            {
                //UC2 - The Player rolls the die to get a number between 1 to 6.
                die = random.Next(1, 7);
                if (count % 2 == 0)
                {
                    //UC3 - Adding option for Ladder, Snake and No Play
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case 0: //snake
                            Console.WriteLine("\n{0} - It's a Snake with {1} points", playerOne, die);
                            pOnePos = pOnePos - die; //move behind by points
                            if (pOnePos < 0)
                            {
                                pOnePos = 0;
                            }
                            //UC6 -  Counting the die roll
                            dieCount1++;
                            break;
                        case 1: //ladder
                            Console.WriteLine("\n{0} - It's a Ladder with {1} points", playerOne, die);
                            pOnePos = pOnePos + die; //move ahead by points
                                                     //UC5 - Ensure the player gets exact winning position 100.
                            if (pOnePos > 100)
                            {
                                pOnePos = pOnePos - die;
                            }
                            //UC6 - Counting the die roll 
                            dieCount1++;
                            break;
                        default: //No Play
                            Console.WriteLine("\n{0} - It's a no Play, No Points", playerOne);
                            pOnePos = pOnePos + 0;
                            break;
                    }
                    Console.WriteLine("{0} is at {1} position.", playerOne, pOnePos);
                    count++;
                }
                else //For Player 2
                {
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case 0: //snake
                            Console.WriteLine("\n{0} - It's a Snake with {1} points", playerTwo, die);
                            pTwoPos = pTwoPos - die; //move behind by points
                            if (pTwoPos < 0)
                            {
                                pTwoPos = 0;
                            }
                            dieCount2++;
                            break;
                        case 1: //ladder
                            Console.WriteLine("\n{0} - It's a Ladder with {1} points", playerTwo, die);
                            pTwoPos = pTwoPos + die; //move ahead by points
                            if (pTwoPos > 100)
                            {
                                pTwoPos = pTwoPos - die;
                            }
                            dieCount2++;
                            break;
                        default: //No Play
                            Console.WriteLine("\n{0} - It's a no Play, No Points", playerTwo);
                            pTwoPos = pTwoPos + 0;
                            break;
                    }
                    Console.WriteLine("{0} is at {1} position.", playerTwo, pTwoPos);
                    count++;
                }
                
            }
            Console.WriteLine("\nPlayer {0} rolled the die for {1} times", playerOne, dieCount1);
            Console.WriteLine("Player {0} rolled the die for {1} times", playerTwo, dieCount2);

            if (pOnePos > pTwoPos)
            {
                Console.WriteLine("\nCongratulation {0}! You Won the Game.",playerOne);
            }
            else
            {
                Console.WriteLine("\nCongratulation {0}! You Won the Game.",playerTwo);
            }
            
            
        }
    }
}

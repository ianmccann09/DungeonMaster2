using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    static class Program
    {
        static void Main(string[] args)
        {
             
            string[] hands = new[] { "r", "p", "s" };

            Random rnd = new Random();
            int hand = rnd.Next(3);
            string computerhand = hands[hand];
            string playerhand = Console.ReadLine();
            
            //int attack = AddNumbers(10, 7);
            //AddNumbers addNumbers = new AddNumbers();

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(playerhand);
            Console.WriteLine(computerhand);
            Console.ReadLine();
            
            bool playAgain = true;
            while (playAgain)
            {
                int Computer = 0;
                int Player = 0;
                
                while (Computer < 4)
                {
                    if (computerhand == "r" && playerhand == "s")
                    {
                        Console.WriteLine("Computer Wins");
                        Computer++;
                    }
                    else if (computerhand == "s" && playerhand == "p")
                    {
                        Console.WriteLine("Computer Wins");
                        Computer++;
                    }
                    else if (computerhand == "p" && playerhand == "r")
                    {
                        Console.WriteLine("Computer Wins");
                        Computer++;
                    }
                    else
                    {
                        Console.WriteLine("You Win!!");
                        Player++;
                    }
                }
            Console.WriteLine(Computer);
            Console.WriteLine(Player);
            Console.ReadLine();
            }

        }
    }
}
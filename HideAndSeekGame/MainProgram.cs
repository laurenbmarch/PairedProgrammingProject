using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekGame
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("                Hide and Seek!");
            Console.WriteLine("          By: Denise C. and Lauren M.");
            Console.WriteLine("                September 2021");
            Console.WriteLine("====================================================");
            Console.WriteLine("Would you like to play? (yes/no)");

            string play = Console.ReadLine().ToLower();

            while (play != "yes")
            {
                if (play == "no")
                {
                    Console.WriteLine("OK; goodbye");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("That's not a good answer. Want to play? (yes/no)");
                play = Console.ReadLine();
            }


            Random random = new Random();
            int ComputerChoice = random.Next(1, 4);

            if (ComputerChoice == 1)
            {
                HideAndSeekGame1 GameVersionOne = new HideAndSeekGame1();
                GameVersionOne.Run();
            }
            else if (ComputerChoice == 2)
            {
                HideAndSeekGame2 GameVersionTwo = new HideAndSeekGame2();
                GameVersionTwo.Run();
            }
            else if (ComputerChoice == 3)
            {
                HideAndSeekGame3 GameVersionThree = new HideAndSeekGame3();
                GameVersionThree.Run();
            }


        }    
    }


    
}

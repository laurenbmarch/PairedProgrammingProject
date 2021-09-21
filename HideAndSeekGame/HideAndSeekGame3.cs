using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekGame
{
    class HideAndSeekGame3
    //Hiding Spot is 
    {
        public void Run()
        {
            // Answer is Inside, Basement, Under the Blanket
            string correctHidingLevelOne = "garage";
            string correctHidingLevelTwo = "right side";
            string correctHidingLevelThree = "1"; //under the blankets
            //Series for when the user gets the first, second, and thrid question wrong (at least the first time)
            Console.WriteLine("Great, Let's play! You're it! Try to find me! Choose one: inside, outside, or the garage?");
            string userGuessLevelOne = Console.ReadLine();
            while (userGuessLevelOne != correctHidingLevelOne)
            {
                Console.WriteLine("Nope, I'm not there. Guess again. Inside, outside, or in the garage?");
                string userGuessAgainLevelOne = Console.ReadLine().ToLower();

                if (userGuessAgainLevelOne == correctHidingLevelOne)
                {
                    userGuessLevelOne = userGuessAgainLevelOne;
                    Console.WriteLine("You're on the right track! Now, choose a room to look in: left side, right side, or middle?");
                    string userGuessLevelTwoA = Console.ReadLine().ToLower();

                    while (userGuessLevelTwoA != correctHidingLevelTwo)
                    {
                        Console.WriteLine("Nope, I'm not in there! Guess again: left side, right side, or middle?");
                        string userGuessAgainLevelTwoB = Console.ReadLine().ToLower();

                        if (userGuessAgainLevelTwoB == correctHidingLevelTwo)
                        {
                            userGuessLevelTwoA = userGuessAgainLevelTwoB;  //Add this on each level
                            Console.WriteLine("You're getting closer! Now, where are you going to look next? \n" +
                            "1. In the freezer\n" +
                            "2. Under the car\n" +
                            "3. Under the workbench\n" +
                            "Enter 1, 2, or 3");
                            string userGuessLevelThreeC = Console.ReadLine();

                            while (userGuessLevelThreeC != correctHidingLevelThree)
                            {
                                Console.WriteLine("Womp! Womp! Not there! Guess again:\n" +
                                "1. In the freezer\n" +
                                "2. Under the car\n" +
                                "3. Under the workbench\n" +
                                  "Enter 1, 2, or 3");
                                string userGuessAgainLevelThreeC = Console.ReadLine();

                                if (userGuessAgainLevelThreeC == correctHidingLevelThree)
                                {
                                    userGuessLevelThreeC = userGuessAgainLevelThreeC;   //Add this on each level
                                    Console.WriteLine("You found me! You win! Thanks for playing. Bye!");
                                    Console.ReadKey();
                                    return;
                                }
                            }
                            Console.WriteLine("You found me! You win! Thanks for playing. Bye!"); //THIS IS WHAT IS JUST ADDED
                            Console.ReadKey();
                            return;
                        }
                    }
                    if (userGuessLevelTwoA == correctHidingLevelTwo)  //THIS IS WHAT I ADDED PART TWO. Essentially the option for if they get Q1 wrong the first time, and Q2 correct the first time
                    {
                        Console.WriteLine("You're getting closer! Now, where are you going to look next? \n" +
                               "1. In the freezer\n" +
                                "2. Under the car\n" +
                                "3. Under the workbench\n" +
                                  "Enter 1, 2, or 3");
                        string userGuessLevelThreeC = Console.ReadLine();

                        while (userGuessLevelThreeC != correctHidingLevelThree)
                        {
                            Console.WriteLine("Womp! Womp! Not there! Guess again:\n" +
                            "1. In the freezer\n" +
                            "2. Under the car\n" +
                            "3. Under the workbench\n" +
                                  "Enter 1, 2, or 3");

                            string userGuessAgainLevelThreeC = Console.ReadLine();

                            if (userGuessAgainLevelThreeC == correctHidingLevelThree)
                            {
                                userGuessLevelThreeC = userGuessAgainLevelThreeC;   //Add this on each level
                                Console.WriteLine("You found me! You win! Thanks for playing. Bye!");
                                Console.ReadKey();
                                return;
                            }
                            
                        }
                        Console.WriteLine("You found me! You win! Thanks for playing. Bye!"); //THIS IS WHAT IS JUST ADDED
                        Console.ReadKey();
                        return;
                    }


                }
            }

            //Series for when the user gets the first question correct on the first try, but misses the second and third questions on the first try.
            Console.WriteLine("You're on the right track! Now, choose a room to look in: right side, left side, or middle?");
            string userGuessLevelTwo = Console.ReadLine().ToLower();
            while (userGuessLevelTwo != correctHidingLevelTwo)
            {
                Console.WriteLine("Nope, I'm not in there! Guess again: right side, left side, or middle?");
                string userGuessAgainLevelTwo = Console.ReadLine().ToLower();

                if (userGuessAgainLevelTwo == correctHidingLevelTwo)
                {
                    userGuessLevelTwo = userGuessAgainLevelTwo;
                    Console.WriteLine("You're getting closer! Now, where are you going to look next? \n" +
                     "1. In the freezer\n" +
                     "2. Under the car\n" +
                     "3. Under the workbench\n" +
                     "Enter 1, 2, or 3");
                    string userGuessLevelThreeD = Console.ReadLine();

                    while (userGuessLevelThreeD != correctHidingLevelThree)
                    {
                        Console.WriteLine("Womp! Womp! Not there! Guess again:\n" +
                    "1. In the freezer\n" +
                    "2. Under the car\n" +
                    "3. Under the workbench\n" +
                     "Enter 1, 2, or 3");
                        string userGuessAgainLevelThreeD = Console.ReadLine();

                        if (userGuessAgainLevelThreeD == correctHidingLevelThree)
                        {
                            userGuessLevelThreeD = userGuessAgainLevelThreeD;
                            Console.WriteLine("You found me! You win! Thanks for playing.");
                            Console.ReadKey();
                            return;
                        }

                    }
                    Console.WriteLine("You found me! You win! Thanks for playing. Bye!"); //THIS IS WHAT IS JUST ADDED
                    Console.ReadKey();
                    return;
                }
            }

            //Series for when the user gets the first and second questions correc ton the first try, but misses the third question on the first try.
            Console.WriteLine("You're getting closer! Now, where are you going to look next? \n" +
                "1. In the freezer\n" +
                "2. Under the car\n" +
                "3. Under the workbench\n" +
                "Enter 1, 2, or 3");
            string userGuessLevelThree = Console.ReadLine();

            while (userGuessLevelThree != correctHidingLevelThree)
            {
                Console.WriteLine("Womp! Womp! Not there! Guess again:\n" +
                    "1. In the freezer\n" +
                    "2. Under the car\n" +
                    "3. Under the workbench\n" +
                    "Enter 1, 2, or 3");
                string userGuessAgainLevelThree = Console.ReadLine();

                if (userGuessAgainLevelThree == correctHidingLevelThree)
                {
                    userGuessLevelThree = userGuessAgainLevelThree;
                    Console.WriteLine("You found me! You win! Thanks for playing.");    //Question
                    Console.ReadKey();
                }
            }
            Console.WriteLine("You found me! You win! Thanks for playing.");    //Question
            Console.ReadKey();
        }
    }
}

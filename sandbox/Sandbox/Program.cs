using System;

class AdventureGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        Console.WriteLine("You find yourself standing at a fork in the road.");

        while (true)
        {
            Console.WriteLine("Which path will you choose? (1 or 2)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You head down the path to the left and come across a small stream.");
                Console.WriteLine("Do you want to follow the stream upstream or downstream? (U/D)");
                string direction = Console.ReadLine();

                if (direction.ToUpper() == "U")
                {
                    Console.WriteLine("You follow the stream upstream and find a hidden cave.");
                    Console.WriteLine("Inside the cave, you discover a treasure chest filled with gold!");
                    Console.WriteLine("Congratulations, you win!");
                    break;
                }
                else if (direction.ToUpper() == "D")
                {
                    Console.WriteLine("You follow the stream downstream and get lost in the woods.");
                    Console.WriteLine("Sorry, you lose.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("You head down the path to the right and come across a rope bridge.");
                Console.WriteLine("Do you want to cross the bridge or turn back? (C/T)");
                string action = Console.ReadLine();

                if (action.ToUpper() == "C")
                {
                    Console.WriteLine("You cross the rope bridge and find a treasure map!");
                    Console.WriteLine("The map leads you to a hidden cave filled with gold.");
                    Console.WriteLine("Congratulations, you win!");
                    break;
                }
                else if (action.ToUpper() == "T")
                {
                    Console.WriteLine("You turn back and get lost in the woods.");
                    Console.WriteLine("Sorry, you lose.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }

        Console.WriteLine("Thanks for playing the Adventure Game! Press any key to exit.");
        Console.ReadKey();
    }
}

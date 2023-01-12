using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // BEGINNING OF PROJECT

        string keepPlaying;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);

            int guess = -1;
            int count = 0;

            while (guess != number)
            {
                System.Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                count += 1;

                if (guess < number)
                {
                    System.Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    System.Console.WriteLine("Lower");
                }
                else
                {
                    System.Console.WriteLine("You guessed it!");
                    System.Console.WriteLine($"It took you {count} tries.");
                }
            }

            System.Console.Write("Keep playing? (yes/no) ");
            keepPlaying = Console.ReadLine();
        } while (keepPlaying == "yes");
        // END OF PROJECT 
    }
} 
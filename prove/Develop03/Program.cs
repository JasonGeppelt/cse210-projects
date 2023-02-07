using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the Scripture Memorizer");
        string response;
        do
        {
            System.Console.Write("Press enter to continue or type 'quit' to quit. ");
            response = System.Console.ReadLine();

            // Random randomGenerator = new Random();
            // int number = randomGenerator.Next(1, 101);

            List<string> verses = new List<string>
            {
                "And it came to pass",
                "the house is blue",
                "the end"
            };

            Scripture scrip = new Scripture(verses);
            scrip.Display();

        } while (response != "quit");
    }
}
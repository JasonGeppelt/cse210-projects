using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        System.Console.WriteLine("\nWelcome to the Scripture Memorizer\n");
        string response;

        string title = "Matthew 5: 14-16 ";
        System.Console.WriteLine(title);

        List<string> verses = new List<string>
        {
            "Ye are the light of the world. A city that is set on an hill cannot be hid.",
            "Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house.",
            "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven." 
        };

        Scripture scrip = new Scripture(verses);

        do
        {   
            Console.SetCursorPosition(0, 4);
            scrip.Display();

            System.Console.WriteLine();
            System.Console.WriteLine("\nPress enter to continue or type 'quit' to quit. ");
            response = System.Console.ReadLine();

        } while (response != "quit");
    }
}
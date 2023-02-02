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
        }
        while (response != "quit");
    }
}
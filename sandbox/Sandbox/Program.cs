using System;

class Program
{
    static void Main(string[] args)
    {   
        // learning how to use if else
        int x = 7;
        int y = 8;
        if (x > y)
        {
            Console.WriteLine("greater");
        }
        else
        {
            Console.WriteLine("Lesser");
        }

        // learning how to combine variables and strings
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");
    }
}
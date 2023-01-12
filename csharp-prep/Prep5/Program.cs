using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        System.Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    
    static int PromptUserNumber()
    {
        System.Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        System.Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
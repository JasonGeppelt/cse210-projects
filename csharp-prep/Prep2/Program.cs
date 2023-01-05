using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("What is your grade percentage? ");
        string stringGrade = Console.ReadLine();
        int numberGrade = int.Parse(stringGrade);

        string letter = "";

        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        System.Console.WriteLine($"Your letter grade is {letter}.");

        if (numberGrade >= 70)
        {
            System.Console.WriteLine("You passed!");
        }
        else
        {
            System.Console.WriteLine("You did not pass, try again next time!");
        }
        
    }
}
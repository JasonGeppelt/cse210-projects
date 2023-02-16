using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Jason Geppelt", "Mathamatics");
        System.Console.WriteLine(assignment1.GetSummary()); 

        MathAssignment mathAssignment1 = new MathAssignment("Jason Geppelt", "Fractions", "7.3", "8-19");
        System.Console.WriteLine(mathAssignment1.GetSummary());
        System.Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Jason Geppelt", "European History", "The Causes of World War II");
        System.Console.WriteLine(writingAssignment1.GetSummary());
        System.Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}
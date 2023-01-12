using System;

class Program
{
    static void Main(string[] args)
    {
        // BEGINNING OF PROJECT

        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int input;
        int sum = 0;
        double average;
        int largest = 0;
        int smallestPositive = 999999999;

        do
        {
            System.Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
            else
            {
                foreach (int number in numbers)
                {
                    sum += number;
                    if (number > largest)
                    {
                        largest = number;
                    }
                    if (number > 0)
                    {
                        if (number < smallestPositive)
                        {
                            smallestPositive = number;
                        }
                    }
                }
                average = (double)sum / (double)(numbers.Count);

                System.Console.WriteLine($"The sum is: {sum}");
                System.Console.WriteLine($"The average is: {average}");
                System.Console.WriteLine($"The largest number is: {largest}");
                System.Console.WriteLine($"The smallest positive number is: {smallestPositive}");

                System.Console.WriteLine("The sorted list is:");
                numbers.Sort();
                foreach (int number in numbers)
                {
                    System.Console.WriteLine(number);
                }
            }
        } while (input != 0);

        // END OF PROJECT 
    }
}
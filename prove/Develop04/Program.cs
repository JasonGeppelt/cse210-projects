using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("\nWelcome to Activity Guide! Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Activity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case "2":
                    Activity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    break;
                case "3":
                    Activity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using Activity Guide. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

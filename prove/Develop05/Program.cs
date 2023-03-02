using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add a simple goal");
            Console.WriteLine("2. Add an eternal goal");
            Console.WriteLine("3. Add a checklist goal");
            Console.WriteLine("4. Record an event");
            Console.WriteLine("5. Display goals");
            Console.WriteLine("6. Save goals to file");
            Console.WriteLine("7. Load goals from file");
            Console.WriteLine("8. Quit");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    // Add a simple goal
                    case 1:
                       
                        break;
                    // Add an eternal goal
                    case 2:
                        
                        break;
                    // Add a checklist goal
                    case 3:
                        
                        break;
                    // Record an event
                    case 4:
                        
                        break;
                    // Display goals
                    case 5:
                        
                        break;
                    // Save goals to file
                    case 6:
                        
                        break;
                    // Load goals from file
                    case 7:
                        
                        break;
                    // Quit
                    case 8:
                        
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
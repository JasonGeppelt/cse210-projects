using System;

class Program
{
    static void Main(string[] args)
    {
        int pointTotal = 0;
        List<Goal> goals = new List<Goal>();

        Console.Clear();
        while (true)
        {
            Console.WriteLine($"\nCurrent points: {pointTotal}\n");
            
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add a simple goal");
            Console.WriteLine("2. Add an eternal goal");
            Console.WriteLine("3. Add a checklist goal");
            Console.WriteLine("4. Record an event");
            Console.WriteLine("5. Display goals");
            Console.WriteLine("6. Save goals to file");
            Console.WriteLine("7. Load goals from file");
            Console.WriteLine("8. Quit\n");

            Console.Write("What do you want to do? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    // Add a simple goal
                    case 1:
                        System.Console.Write("What is the name of your simple goal? ");
                        string simpleTitle = Console.ReadLine();
                        System.Console.WriteLine("Give a description of the goal.");
                        string simpleDescription = Console.ReadLine();
                        System.Console.Write("What is the point value of this goal? ");
                        int simplePointValue = int.Parse(Console.ReadLine());
                        SimpleGoal simpleGoal = new SimpleGoal(simplePointValue, simpleTitle, simpleDescription);
                        simpleGoal.SetGoalType("Simple Goal");
                        goals.Add(simpleGoal);
                        break;

                    // Add an eternal goal
                    case 2:
                        System.Console.Write("What is the name of your eternal goal? ");
                        string eternalTitle = Console.ReadLine();
                        System.Console.WriteLine("Give a description of the goal.");
                        string eternalDescription = Console.ReadLine();
                        System.Console.Write("How many points do you earn each time you complete this goal? ");
                        int eternalPointValue = int.Parse(Console.ReadLine());
                        EternalGoal eternalGoal = new EternalGoal(eternalPointValue, eternalTitle, eternalDescription);
                        eternalGoal.SetGoalType("Eternal Goal");
                        goals.Add(eternalGoal);
                        break;

                    // Add a checklist goal
                    case 3:
                        
                        break;

                    // Record an event
                    case 4:
                        
                        break;

                    // Display goals
                    case 5:
                        System.Console.WriteLine("\n---------------------------");
                        System.Console.WriteLine("YOUR GOALS\n");
                        foreach (Goal goal in goals)
                        {
                            System.Console.WriteLine($"{goal.GetGoalType()}:");
                            System.Console.WriteLine(goal.GetTitle());
                            System.Console.WriteLine(goal.GetDescription());
                            System.Console.WriteLine($"{goal.GetPointValue()}\n");
                        }
                        System.Console.WriteLine("---------------------------");
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
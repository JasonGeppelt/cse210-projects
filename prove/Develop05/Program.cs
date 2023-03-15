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
                        Console.Clear();
                        System.Console.Write("What is the name of your simple goal? ");
                        string simpleTitle = Console.ReadLine();
                        System.Console.WriteLine("Give a description of the goal.");
                        string simpleDescription = Console.ReadLine();
                        System.Console.Write("What is the point value of this goal? ");
                        int simplePointValue = int.Parse(Console.ReadLine());
                        SimpleGoal simpleGoal = new SimpleGoal(simplePointValue, simpleTitle, simpleDescription);
                        simpleGoal.Type = "Simple Goal";
                        goals.Add(simpleGoal);
                        break;

                    // Add an eternal goal
                    case 2:
                        Console.Clear();
                        System.Console.Write("What is the name of your eternal goal? ");
                        string eternalTitle = Console.ReadLine();
                        System.Console.WriteLine("Give a description of the goal.");
                        string eternalDescription = Console.ReadLine();
                        System.Console.Write("How many points do you earn each time you complete this goal? ");
                        int eternalPointValue = int.Parse(Console.ReadLine());
                        EternalGoal eternalGoal = new EternalGoal(eternalPointValue, eternalTitle, eternalDescription);
                        eternalGoal.Type ="Eternal Goal";
                        goals.Add(eternalGoal);
                        break;

                    // Add a checklist goal
                    case 3:
                        Console.Clear();
                        System.Console.Write("What is the name of your checklist goal? ");
                        string checklistTitle = Console.ReadLine();
                        System.Console.WriteLine("Give a description of the goal.");
                        string checklistDescription = Console.ReadLine();
                        System.Console.Write("How many times do you need to complete this goal? ");
                        int repetitionNum = int.Parse(Console.ReadLine());
                        System.Console.Write("How many points do you earn each time you complete this goal? ");
                        int checklistPointValue = int.Parse(Console.ReadLine());
                        System.Console.Write("How many bonus points will you earn when you complete all required repetitions of this goal? ");
                        int bonusPointValue = int.Parse(Console.ReadLine());
                        Checklist checklist = new Checklist(checklistPointValue, checklistTitle, checklistDescription, repetitionNum, bonusPointValue);
                        checklist.Type = "Checklist";
                        goals.Add(checklist);
                        break;

                    // Record an event
                    case 4:
                        Console.Clear();
                        System.Console.WriteLine("\n---------------------------");
                        System.Console.WriteLine("Choose a goal to record an event under:\n");
                        int number = 1;
                        foreach (Goal goal in goals)
                        {
                            if (goal.IsComplete == false)
                            {
                                System.Console.Write($"{number}) ");
                                goal.Display();
                                number++;
                            }
                        }
                        System.Console.WriteLine("---------------------------");
                        System.Console.WriteLine("Which goal do you choose? ");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        pointTotal += goals[index].RecordEvent();
                        break;

                    // Display goals
                    case 5:
                        Console.Clear();
                        System.Console.WriteLine("\n---------------------------");
                        System.Console.WriteLine("YOUR GOALS\n");
                        foreach (Goal goal in goals)
                        {
                            goal.Display();
                        }
                        System.Console.WriteLine("---------------------------");
                        break;

                    // Save goals to file
                    case 6:
                        Console.Clear();
                        foreach (Goal goal in goals)
                        {
                            goal.Save();
                        }
                        System.Console.WriteLine("File saved.");
                        break;

                    // Load goals from file
                    case 7:
                        Console.Clear();
                        if (File.Exists("goals.txt"))
                        {
                            using (StreamReader reader = new StreamReader("goals.txt"))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {

                                    string[] values = line.Split('|');
                                    if (values[0] == "Simple Goal")
                                    {
                                        SimpleGoal simpleGoal1 = new SimpleGoal(int.Parse(values[1]), values[2], values[3]);
                                        simpleGoal1.Type = values[0];
                                        simpleGoal1.IsComplete = bool.Parse(values[4]);
                                        goals.Add(simpleGoal1);
                                    }
                                    else if (values[0] == "Eternal Goal")
                                    {
                                        EternalGoal eternalGoal1 = new EternalGoal(int.Parse(values[1]), values[2], values[3]);
                                        eternalGoal1.Type = values[0];
                                        eternalGoal1.IsComplete = bool.Parse(values[4]);
                                        goals.Add(eternalGoal1);
                                    }
                                    else if (values[0] == "Checklist")
                                    {
                                        Checklist checklist1 = new Checklist(int.Parse(values[1]), values[2], values[3], int.Parse(values[5]), int.Parse(values[6]));
                                        checklist1.Type = values[0];
                                        checklist1.IsComplete = bool.Parse(values[4]);
                                        goals.Add(checklist1);
                                    }
                                }
                            }
                        }
                        System.Console.WriteLine("File loaded.");
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
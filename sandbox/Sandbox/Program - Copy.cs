// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Goals goals = Goals.LoadFromFile("goals.bin");

//         while (true)
//         {
//             Console.WriteLine("What do you want to do?");
//             Console.WriteLine("1. Add a simple goal");
//             Console.WriteLine("2. Add an eternal goal");
//             Console.WriteLine("3. Add a checklist goal");
//             Console.WriteLine("4. Record an event");
//             Console.WriteLine("5. Display goals");
//             Console.WriteLine("6. Save goals to file");
//             Console.WriteLine("7. Load goals from file");
//             Console.WriteLine("8. Quit");

//             string input = Console.ReadLine();

//             if (int.TryParse(input, out int choice))
//             {
//                 switch (choice)
//                 {
//                     case 1:
//                         Console.Write("Enter goal name: ");
//                         string simpleName = Console.ReadLine();
//                         Console.Write("Enter goal value: ");
//                         if (int.TryParse(Console.ReadLine(), out int simpleValue))
//                         {
//                             goals.AddGoal(new SimpleGoal(simpleName, simpleValue));
//                         }
//                         break;
//                     case 2:
//                         Console.Write("Enter goal name: ");
//                         string eternalName = Console.ReadLine();
//                         Console.Write("Enter goal value: ");
//                         if (int.TryParse(Console.ReadLine(), out int eternalValue))
//                         {
//                             goals.AddGoal(new EternalGoal(eternalName, eternalValue));
//                         }
//                         break;
//                     case 3:
//                         Console.Write("Enter goal name: ");
//                         string checklistName = Console.ReadLine();
//                         Console.Write("Enter goal value: ");
//                         if (int.TryParse(Console.ReadLine(), out int checklistValue))
//                         {
//                             Console.Write("Enter checklist target: ");
//                             if (int.TryParse(Console.ReadLine(), out int checklistTarget))
//                             {
//                                 goals.AddGoal(new Checklist(checklistName, checklistValue, checklistTarget));
//                             }
//                         }
//                         break;
//                     case 4:
//                         Console.Write("Enter goal index: ");
//                         if (int.TryParse(Console.ReadLine(), out int index))
//                         {
//                             goals.RecordEvent(index);
//                         }
//                         break;
//                     case 5:
//                         goals.DisplayGoals();
//                         break;
//                     case 6:
//                         Console.Write("Enter filename: ");
//                         string filename = Console.ReadLine();
//                         goals.SaveToFile(filename);
//                         break;
//                     case 7:
//                         Console.Write("Enter filename: ");
//                         string loadFilename = Console.ReadLine();
//                         goals = Goals.LoadFromFile(loadFilename);
//                         break;
//                     case 8:
//                         goals.SaveToFile("goals.bin");
//                         return;
//                     default:
//                         Console.WriteLine("Invalid choice");
//                         break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input");
//             }
//         }
//     }
// }
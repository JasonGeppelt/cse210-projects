using System;

// Shopping Cart Program

        /*
        1) Add Item
        2) Display
        3) Total
        4) Remove
        5) Quit
        */


class Program
{
    static void Main(string[] args)
    {   
        // Data
        List<string> items = new List<string>();
        List<float> prices = new List<float>();

        bool done = false;
        while (!done)
        {
            DisplayMenu();
            int choice = GetChoice();
            if (choice == 1)
            {
                AddItem(items, prices);
            }
            if (choice == 2)
            {
                Display(items, prices);
            }
            if (choice == 3)
            {
                Display(items, prices);
            }
            if (choice == 4)
            {
                Display(items, prices);
            }
            if (choice == 5)
            {
                System.Console.WriteLine("Thank you, goodbye.");
                done = true;
            }
        }
    }

     static void DisplayMenu()
    {
        System.Console.WriteLine("\n1) Add Item");
        System.Console.WriteLine("2) Display");
        System.Console.WriteLine("3) Total");
        System.Console.WriteLine("4) Remove");
        System.Console.WriteLine("5) Quit\n");
    }
    static int GetChoice()
    {
        System.Console.WriteLine("Enter Choice: ");
        return int.Parse(Console.ReadLine());
    }
    static void AddItem(List<string> items, List<float> prices)
    {
        System.Console.Write("Enter item: ");
        string item = Console.ReadLine();

        System.Console.Write("Enter price: ");
        float price = float.Parse(Console.ReadLine());

        items.Add(item);
        prices.Add(price);
    }
    static void Display(List<string> items, List<float> prices)
    {
        System.Console.WriteLine("DISPLAY ITEMS");
        for (int i = 0; i < items.Count; i++)
        {
            System.Console.WriteLine($"{items[i]}: ${prices[i]}");
        }
    }
    static void Total(List<string> items, List<float> prices)
    {
        System.Console.WriteLine("TOTAL");
    }
    static void Remove(List<string> items, List<float> prices)
    {
        System.Console.WriteLine("REMOVE");
    }
}
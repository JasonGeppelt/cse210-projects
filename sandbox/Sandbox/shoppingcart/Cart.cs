using System;
using System.Collections.Generic;

class Cart
{
    public List<Item> _items = new List<Item>();
    public void Display()
    {
        foreach (Item item in _items)
        {
            item.Display();
        }
    }
    public void AddItem()
    {
        System.Console.WriteLine("Enter Description: ");
        string desc = Console.ReadLine();
        
        System.Console.WriteLine("Enter Price: ");
        float price = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Count: ");
        int count = int.Parse(Console.ReadLine());


    }
    public void RemoveItem()
    {

    }
}
using System;
class Item
{
    public float _price;
    public string _desc;
    public int _count;
    public void Display()
    {
        System.Console.WriteLine($"{_count} {_desc} ${_price * _count}");
    }
}
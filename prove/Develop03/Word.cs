using System;

public class Word
{
    private string _text;
    private bool _hidden;  
    
    public Word(string text)
    {
        _text = text;
    }

    public void Display()
    {
        if (_hidden)
        {
            foreach (char c in _text)
            {
                System.Console.Write("_");
            }
        } else
        {
            System.Console.Write(_text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public string _body = "";

    public void Save()
    {
        System.Console.Write("Please enter the name of the file you would like to save your journal to: ");
        string fileName = System.Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_body}");
        }
    }

    public void Load()
    {
        System.Console.Write("Please enter the name of the file you would like to read: ");
        string loadFile = System.Console.ReadLine();
        string contentFile = File.ReadAllText(loadFile);
        _body += contentFile;
    }

    public void Display()
    {
        System.Console.WriteLine($"{_body}");
    }

}
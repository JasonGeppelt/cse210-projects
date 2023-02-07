using System;
using System.Collections.Generic;
using System.IO;
class Entry
{

    public string Prompt(string _entryAnswer)
    {
     
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        List<string> list = new List<string>();
        list.Add("What was your favorite part of the day?");
        list.Add("What was one funny thing that happend today?");
        list.Add("How did you see the lords hand today?");
        list.Add("Who was the first person you talked to today?");
        list.Add("What was an interesting thing you saw today?");
        list.Add("Did you read your scriptures today? What did you learn?");
      
        var r = new Random();
        int count = list.Count;
        int indexVal = r.Next(count);
       
        var prompt = list[indexVal];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string finalResponse = $"\n\nEntry date: {dateText} - {prompt} \n> {response}";

        return finalResponse;
    }
}
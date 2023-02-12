using System;

class Scripture
{
    private List<Verse> _verses = new List<Verse>();

    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
        // System.Console.WriteLine("# of verses: " + _verses.Count);
    }

    public void Display()
    {

        foreach (Verse v in _verses)
        {
            v.Display();
        }
        RandomBlank();
        RandomBlank();
        RandomBlank();
    }

    public void RandomBlank()
    {
        int count = 0;
        foreach (Verse verse in _verses)
        {
            if (verse._hidden == false)
            {
                count++;
            }
        }

        if (count > 0)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _verses.Count);
            // System.Console.WriteLine("random verses index: " + number);

            if (!_verses[number]._hidden)
            {
                _verses[number].RandomBlank();
            }
            else
            {
                RandomBlank();
            }       
        }
        else
        {
            return;
        }
    }
}
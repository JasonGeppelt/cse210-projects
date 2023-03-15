using System;

class Verse
{
    public bool _hidden;

    private List<Word> _words = new List<Word>();

    public Verse(string verse)
    {
        char[] delimiterChars = {' ', '\t'};
        string[] words = verse.Split(delimiterChars);
        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }
        // System.Console.WriteLine("# of words: " + _words.Count);
    }
    
    public void Display()
    {
        foreach (Word w in _words)
        {
            w.Display();
            System.Console.Write(" ");
        }
    }

    public void RandomBlank()
    {   
        int count = 0;
        foreach (Word word in _words)
        {
            if (word._hidden == false)
            {
                count++;
            }
        }

        if (count > 0)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _words.Count);
            // System.Console.WriteLine("random words index: " + number);

            if (!_words[number]._hidden)
            {
                _words[number].RandomBlank();
            }
            else
            {
                RandomBlank();
            }
        }
        else
        {
            _hidden = true;
        }
    }
}
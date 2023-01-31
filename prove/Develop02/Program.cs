using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the Journal Program!");

        char selection;
        do
        {
            string menu = @"Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit";
            System.Console.WriteLine(menu);
            System.Console.Write("What would you like to do? ");
            selection = char.Parse(System.Console.ReadLine());

            switch(selection) 
            {
                case '1':
                    // code block
                    break;

                case '2':
                    // code block
                    break;

                case '3':
                    System.Console.WriteLine("you chose 3.");
                    break;

                case '4':
                    // code block
                    break;

                case '5':
                    System.Console.WriteLine("Thank you, goodbye.");
                    break;

                default:
                    System.Console.WriteLine("ERROR, please enter a number between 1-5.");
                    break;
            }
        }
        while (selection != '5');
    }
}
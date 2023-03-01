class ListingActivity : Activity
{
    private List<string> responceList= new List<string>();

    public override void Start()
    {
        Console.WriteLine("\nStarting Listing Activity...");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int duration = GetDuration();
        Console.WriteLine($"You will make a list for {duration} seconds. Get ready!");

        PauseWithDots(3);

        int count = Listing(duration);
        Console.WriteLine($"You made a list of {count} items!");

        End(duration);
        PauseWithDots(3);
    }

    public int Listing(int duration)
    {
        string[] prompts = {"Who are people that you appreciate?",
                            "What are personal strengths of yours?",
                            "Who are people that you have helped this week?",
                            "When have you felt the Holy Ghost this month?",
                            "Who are some of your personal heroes?"};
        List<string> promptList = new List<string>(prompts);

        Random random = new Random();

        int index = random.Next(promptList.Count);
        Console.WriteLine(promptList[index]);
        
        int count = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Add to your list: ");
            string item = Console.ReadLine();
            count++;
        }

        return count;
        
        Console.WriteLine();
    }
}
abstract class Activity
{
    public abstract void Start();

    public void End(int duration)
    {
        Console.WriteLine($"You have completed the activity for {duration} seconds. Great job!");
    }

    public int GetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        string input = Console.ReadLine();
        int duration = int.Parse(input);
        return duration;
    }

    public void PauseWithDots(int seconds)
    {
        Console.Write("Loading ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
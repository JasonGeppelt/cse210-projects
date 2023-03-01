class BreathingActivity : Activity
{
    public override void Start()
    {
        Console.WriteLine("\nStarting Breathing Activity...");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int duration = GetDuration();
        Console.WriteLine($"You will breathe deeply for {duration} seconds. Get ready!");

        PauseWithDots(3);

        Console.WriteLine("Begin breathing deeply now.");
        BreathingPauses(duration);

        End(duration);
        PauseWithDots(3);
    }

    public void BreathingPauses(int duration)
    {
        int count = 0;
        while (count < duration)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"Breath in... {i}");
                Thread.Sleep(1000);
                count++;
                Console.Write("\r" + new string(' ', Console.WindowWidth - Console.CursorLeft - 1) + "\r");
            }

            for (int i = 4; i > 0; i--)
            {
                Console.Write($"Breath out... {i}");
                Thread.Sleep(1000);
                count++;
                Console.Write("\r" + new string(' ', Console.WindowWidth - Console.CursorLeft - 1) + "\r");
            }
        }
        Console.WriteLine();
    }
}
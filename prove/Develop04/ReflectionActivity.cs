class ReflectionActivity : Activity
{
    public override void Start()
    {
        Console.WriteLine("\nStarting Reflection Activity...");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int duration = GetDuration();
        Console.WriteLine($"You will reflect for {duration} seconds. Get ready!");

        PauseWithDots(3);

        List<string> promptList = new List<string>();
        promptList.Add("Think of a time when you stood up for someone else.");
        promptList.Add("Think of a time when you did something really difficult.");
        promptList.Add("Think of a time when you helped someone in need.");
        promptList.Add("Think of a time when you did something truly selfless.");

        string[] reflections = {"Why was this experience meaningful to you?",
                                "Have you ever done anything like this before?",
                                "How did you get started?",
                                "How did you feel when it was complete?",
                                "What made this time different than other times when you were not as successful?",
                                "What is your favorite thing about this experience?",
                                "What could you learn from this experience that applies to other situations?",
                                "What did you learn about yourself through this experience?",
                                "How can you keep this experience in mind in the future?"};
        List<string> reflectList = new List<string>(reflections);
       

        Random random = new Random();

        int promptIndex = random.Next(promptList.Count);
        Console.WriteLine(promptList[promptIndex]);

        Console.WriteLine("Press enter when you have something in mind.");
        Console.ReadLine();

        List<string> displayedReflections = new List<string>();

        int count = 0;
        while (count < duration && displayedReflections.Count < reflectList.Count)
        {
            int index = random.Next(reflectList.Count);
            if (!displayedReflections.Contains(reflectList[index]))
            {
                Console.WriteLine(reflectList[index]);
                SpinnerPause();
                displayedReflections.Add(reflectList[index]);
                count += 10;
            }
        }

        End(duration);
        PauseWithDots(3);
    }

    public void SpinnerPause()
    {
        int count = 0;
        while (count < 20)
        {
            Console.Write("\r/");
            Thread.Sleep(500);
            count++;
            Console.Write("\r-");
            Thread.Sleep(500);
            count++;
            Console.Write("\r\\");
            Thread.Sleep(500);
            count++;
            Console.Write("\r|");
            Thread.Sleep(500);
            count++;
        }
        Console.WriteLine("\r ");
    }
}
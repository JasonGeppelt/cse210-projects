class Program
{
    static void Main()
    {
        int time = 10;
        int speed = 200;

        while (time > 0)
        {
            System.Console.Write("/");
            Thread.Sleep(speed);
            System.Console.Write("\b");
            System.Console.Write("―");
            Thread.Sleep(speed);
            System.Console.Write("\b");
            System.Console.Write("\\");
            Thread.Sleep(speed);
            System.Console.Write("\b");
            System.Console.Write("|");
            Thread.Sleep(speed);
            System.Console.Write("\b");
        }
    }
}

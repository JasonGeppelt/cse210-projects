class EternalGoal : Goal
{
    public EternalGoal(int pointValue, string title, string description) : base(pointValue, title, description)
    {
    
    }

    public override void Display()
    {
        string checkmark = " ";
        if (IsComplete == true)
        {
            checkmark = "X";
        }
        System.Console.WriteLine($"[{checkmark}] {Title} ({Description}) | Point Value: {PointValue}");
    }

    public override int RecordEvent()
    {
        return PointValue;
    }

    public override void Save()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt", true))
        {
            writer.WriteLine($"{Type}|{PointValue}|{Title}|{Description}|{IsComplete}");
        }
    }
}
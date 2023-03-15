class SimpleGoal : Goal
{
    public SimpleGoal(int pointValue, string title, string description) : base(pointValue, title, description)
    {
    
    }

    public override void Display()
    {
        string checkmark = " ";
        if (IsComplete == true)
        {
            checkmark = "X";
        }
<<<<<<< HEAD
        System.Console.WriteLine($"[{checkmark}] {Title} | Point Value: {PointValue}");
=======
        System.Console.WriteLine($"{{{checkmark}}} {Title} | Point Value: {PointValue}");
>>>>>>> 97732633f7348dfe9fe9a26b06c1d81bb1532df8
    }

    public override int RecordEvent()
    {
        IsComplete = true;
        return PointValue;
    }

    public override void Save()
    {
        
    }

    public override void Load()
    {
      
    }
}
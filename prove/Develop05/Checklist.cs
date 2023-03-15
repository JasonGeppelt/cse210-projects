class Checklist : Goal
{
    private int _completedNum = 0;
    private int _repetitionNum;
    private int _bonusPointValue;

    public int RepetitionNum
    {
        get { return _repetitionNum; }
        set { _repetitionNum = value; }
    }

    public int BonusPointValue
    {
        get { return _bonusPointValue; }
        set { _bonusPointValue = value; }
    }
    
    public Checklist(int pointValue, string title, string description, int repetitionNum, int bonusPointValue) : base(pointValue, title, description)
    {
        _repetitionNum = repetitionNum;
        _bonusPointValue = bonusPointValue;
    }

    public override void Display()
    {
        string checkmark = " ";
        if (IsComplete == true)
        {
            checkmark = "X";
        }
<<<<<<< HEAD
        System.Console.WriteLine($"[{checkmark}] {Title} | Point Value: {PointValue} | Bonus Point Value: {BonusPointValue} | Current progress: {_completedNum}/{_repetitionNum}");
=======
        System.Console.WriteLine($"{{{checkmark}}} {Title} | Point Value: {PointValue} | Bonus Point Value: {BonusPointValue} | Current progress: {_completedNum}/{_repetitionNum}");
>>>>>>> 97732633f7348dfe9fe9a26b06c1d81bb1532df8
    }

    public override int RecordEvent()
    {
        _completedNum ++;
        if (_completedNum == _repetitionNum)
        {
            IsComplete = true;
            return BonusPointValue;
        }
        return PointValue;
    }

    public override void Save()
    {
        
    }

    public override void Load()
    {
      
    }
}
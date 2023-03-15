public abstract class Goal
{
    private int _pointValue;
    private string _title;
    private string _description;
    private string _type;
    private bool _isComplete;

    public int PointValue
    {
        get { return _pointValue; }
        set { _pointValue = value; }
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public bool IsComplete
    {
        get { return _isComplete; }
        set { _isComplete = value; }
    }

    public Goal(int pointValue, string title, string description)
    {
        PointValue = pointValue;
        Title = title;
        Description = description;
    }

    public abstract void Display();
    public abstract int RecordEvent();
    public abstract void Save();
}
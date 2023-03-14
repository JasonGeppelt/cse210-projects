public abstract class Goal
{
    private int _pointValue;
    private string _title;
    private string _description;
    private string _type;

    public Goal(int pointValue, string title, string description)
    {
        SetPointValue(pointValue);
        SetTitle(title);
        SetDescription(description);
    }

    public void SetPointValue(int pointValue)
    {
        _pointValue = pointValue;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }

    public void SetGoalType(string type)
    {
        _type = type;
    }
    public string GetGoalType()
    {
        return _type;
    }


    public abstract bool IsCompleted();
    public abstract void Save();
    public abstract void Load();
}
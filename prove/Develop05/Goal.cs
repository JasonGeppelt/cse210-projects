public abstract class Goal
{
    private int _pointValue;
    private string _title;
    private string _description;

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
    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public abstract bool IsCompleted();
    public abstract void Save();
    public abstract void Load();
}
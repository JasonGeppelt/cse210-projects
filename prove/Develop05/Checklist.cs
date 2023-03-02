class Checklist : Goal
{
    public Checklist(int pointValue, string title, string description) : base(pointValue, title, description)
    {
    
    }
    
    public override bool IsCompleted()
    {
        return false;
    }

    public override void Save()
    {
        
    }

    public override void Load()
    {
      
    }
}
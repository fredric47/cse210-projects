using System.ComponentModel;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetDetailsString()
    {
        return "";
    }
    
    public string GetStringRepresentation()
    {
        return "";
    }
    
}
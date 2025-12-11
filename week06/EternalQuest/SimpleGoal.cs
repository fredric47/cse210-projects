using System.Globalization;

public class SimpleGoal : Goal
{
    private bool _iscomplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;
    }
    
    public string GetRepresentation()
    {
        return "";
    }
}
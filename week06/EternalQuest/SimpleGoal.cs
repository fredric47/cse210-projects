using System.Globalization;

public class SimpleGoal : Goal
{
    private bool _iscomplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    // public void RecordEvent()
    // {

    // }

    public override bool IsComplete()
    {
        return true;
    }
    
    public override string GetRepresentation()
    {
        return "";
    }
}
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    // private string _goalType;
    // private string _goalName;
    // private string _goalDescription;
    // private int _goalPointAmmount;
    // private int _timesTillBonus;
    // private int _bonusAmmount;

    // public string name1 = "Get Jacked";
    // public string name2 = "Be Awesome";
    // public string description1 = "Workout like mad!";
    // public string description2 = "Be Wise,  productive, and active!";
    // public string points1 = "550";
    // public string points2 = "600";

    public GoalManager()
    {
        Goal goal1 = new Goal("Get Jacked", "Workout like mad", "550");
        Goal goal2 = new Goal("Be Awesome", "Be Wise,  productive, and active!", "600");
        _goals.Add(goal1);
        _goals.Add(goal2);
        LoadGoals();
    }

    public void Start()
    {
        
    }

    public void DispplayPlayerInfo()
    {

    }

    public void ListGoalName()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.Write("What type of Goal do you want to create?");
        Console.Write("What is the name of the goal?");
        Console.Write("What is the discription of the goal?");
        Console.Write("How many points is this goal worth?");

        Console.Write("How many times does this need to be done for a bonus?");
        Console.Write("How many points is that bonus?");

    }
 
    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }
    
    public void LoadGoals()
    {
        // foreach (Goal goal in _goals)
        // {
        //     Console.Write($"\nGoal: {goal._shortName} \nDescription: {goal._description} (worth {goal._points} points)\n");
        // }
        
    }
}
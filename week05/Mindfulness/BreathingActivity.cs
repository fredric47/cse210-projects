using System.Diagnostics.Contracts;
using System.Linq.Expressions;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartMessage(_name);
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long in seconds do you want this activity to last?");
        _duration = int.Parse(Console.ReadLine());
        StartBreathing();
        Console.Clear();
        DisplayEndMessage();
        ShowCountdown(5);
        Console.Clear();
    }
    
    public void StartBreathing()
    {
        int time = 0;
        while (_duration > time) 
        {
            Console.Clear();
            Console.Write("\nBreath in ...\n");
            ShowCountdown(3);
            time += 3;
            Console.Clear();
            Console.Write("\nBreath out ...\n");
            ShowCountdown(3);
            time += 3;
        }
    }
}

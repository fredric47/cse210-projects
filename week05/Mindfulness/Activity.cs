using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string decription, int duration)
    {
        _name = name;
        _description = decription;
        _duration = duration;
    }

    public void DisplayStartMessage(string activityName)
    {
        Console.WriteLine($"Welcome to the {activityName}");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"\nWell done! You just finnished another {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationList = new List<string>();
        animationList.Add("|");
        animationList.Add("/");
        animationList.Add("-");
        animationList.Add("\\");
        animationList.Add("|");
        animationList.Add("/");
        animationList.Add("-");
        animationList.Add("\\");

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationList[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animationList.Count)
            {
                i = 0;
            }
        }
    }
    
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > -1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }
}
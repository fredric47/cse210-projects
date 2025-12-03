using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class ListningActivity : Activity
{

    private int _count = 0;
    private List<string> _prompts = new List<string>();

    private List<string> userAnswerList = new List<string>();

    public ListningActivity(string name, string description, int duration) : base(name, description, duration)
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
        Console.Write("\nHow long in seconds do you want this activity to last? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Please get ready...");
        ShowSpinner(5);
        Console.Clear();
        Console.WriteLine("Now respond to the following prompt as many times as you can");
        AddToPromptList();
        Console.Write("-------");
        GetRandomPrompt();
        Console.Write("-------");
        Console.WriteLine("\nStart in:");
        ShowCountdown(10);
        Console.WriteLine("GO!");
        GetListFromUser();
        Console.WriteLine($"You entered {userAnswerList.Count} responses!");
        ShowSpinner(5);
        DisplayEndMessage();
        ShowSpinner(5);
        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        int listLength = _prompts.Count;
        Random random = new Random();
        int randomIndex = random.Next(0, listLength);
        Console.Write(_prompts[randomIndex]);
    }

    public void AddToPromptList() //:)
    {
        _prompts.Add("How have you seen the hand of God in your life?");
        _prompts.Add("What is a blessing God has given you?");
        _prompts.Add("What is a kindness shown to you today?");
        _prompts.Add("How have you strived to be a Christ like example today?");
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (endTime > DateTime.Now)
        {
            Console.Write(">");
            string listItem = Console.ReadLine();
            userAnswerList.Add(listItem);
            _count++;
        }

        return userAnswerList;
    }
}
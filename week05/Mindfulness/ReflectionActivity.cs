public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
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
        AddToPromptList();
        DisplayRandomPrompt();
        Console.WriteLine("Please press enter when ready to Ponder and Reflect");
        Console.ReadLine();
        Console.Clear();
        AddToPQuestionList();
        StartReflecting();
        ShowSpinner(5);
        DisplayEndMessage();
        ShowSpinner(5);
        Console.Clear();
    }

    public void StartReflecting()
    {
        int time = 0;
        while (_duration > time)
        {
            DisplayRandomQuestion();
            ShowCountdown(10);
            time += 10;
        }
    }

    public void AddToPromptList()
    {
        _prompts.Add("How have you seen the hand of God in your life?");
        _prompts.Add("What is a blessing God has given you?");
        _prompts.Add("What is a kindness shown to you today?");
        _prompts.Add("How have you strived to be a Christ like example today?");
        _prompts.Add("How do you know know God loves You?");
    }

    public void AddToPQuestionList()
    {
        _questions.Add("How has/does this changed your life?");
        _questions.Add("What do you do diferently because of this?");
        _questions.Add("How does this effect how you treat others?");
        _questions.Add("What does this make you feel? & why?");

    }

    public void DisplayRandomPrompt()
    {
        int listLength = _prompts.Count;
        Random random = new Random();
        int randomIndex = random.Next(0, listLength);
        Console.WriteLine(_prompts[randomIndex]);
    }


    int lastIndex = -1;
    public void DisplayRandomQuestion()
    {
        int listLength = _questions.Count;
        Random random = new Random();
        int randomIndex = random.Next(0, listLength);
        while (randomIndex == lastIndex)
        {
            randomIndex = random.Next(0, listLength);
        }
        Console.WriteLine(_questions[randomIndex]);
        lastIndex = randomIndex;
    }
}
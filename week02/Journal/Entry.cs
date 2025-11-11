using System;
public class Entry
{

    public string _date;

    public string _promptText;

    public string _entryText;

    public string Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        PromptGenerator ranP = new PromptGenerator();
        _promptText = ranP.GetRandomPrompt();

        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();

        Console.WriteLine($"\n\t\tDate: {_date} -Prompt:-'{_promptText}'-\n{_entryText}\n");

        return $"\n\t\tDate: {_date} -Prompt:-{_promptText}-\n{_entryText}\n";
    }
}
 
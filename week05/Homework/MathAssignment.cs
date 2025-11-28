using System.Text.Encodings.Web;

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textBookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        string name = GetName();
        string topic = GetTopic();
        return $"\n{name} - {topic} \nSections:{_textBookSection} Problems:{_problems}";
    }
}
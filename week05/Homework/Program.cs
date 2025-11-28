using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        string name = "Fred Rogers";
        string topic = "History";
        string textBookSection = "4-5";
        string problems = "49-61";
        string title = "The Road to Victory";

        Assignment assignment1 = new Assignment(name, topic);
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment(name, "math", textBookSection, problems);
        Console.WriteLine(math1.GetHomeWorkList());

        WritingAssignment writingAssignment1 = new WritingAssignment(name, topic, title);
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}
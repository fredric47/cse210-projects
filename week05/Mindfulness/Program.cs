//To show creativity I made the Reflection activity not give the same question twice in a row
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Activity List: ");
        string selection = "0";
        while (selection != "4")
        {
            Console.Clear();
            Console.WriteLine("\n1. Breathing Activity");
            Console.WriteLine("2. Listning Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What activity would you like to practice: ");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                string name = "Breathing Activity";
                string description = "An activity where you take a break from the busy world and just breath ;)";
                int duration = 0;
                BreathingActivity breathingActivity1 = new BreathingActivity(name, description, duration);
                breathingActivity1.Run();
            }

            if (selection == "2")
            {
                string name = "Listning Activity";
                string description = "An activity where you list answers in response to a question ";
                int duration = 0;
                ListningActivity listningActivity1 = new ListningActivity(name, description, duration);
                listningActivity1.Run();
            }

            if (selection == "3")
            {
                string name = "Refelection Activity";
                string description = "An activity where you take time to reflect on an inspired question ";
                int duration = 0;
                ReflectionActivity reflectionActivity1 = new ReflectionActivity(name, description, duration);
                reflectionActivity1.Run();
            }

        }

        Console.WriteLine("Good-bye");
    }
}
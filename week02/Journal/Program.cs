//To show creativivy I added a function to Journals.cs that is called after saving which clears and trims the _entries list.
//This is to help make sure there won't be any duplicate saves if the user tries to save again after adding another entery. To learn about clear and trim functions I used "https://stackoverflow.com/questions/5311124/how-to-empty-a-list-in-c"
// save1.txt    is the test journal file
using System;
using System.Data;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");


        

        Journal journal = new Journal();

        int action = 0;
        while (action != 5)
        {
            Console.WriteLine("Please select one of the following choices (1-5): ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            action = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (action == 1)//1. Write
            {
                Entry entry = new Entry();
                string datePrompt = entry.Display();
                journal.AddEntry(datePrompt);
            }

            else if (action == 2)//2. display
            {
                journal.DisplayAll();
            }

            else if (action == 3)//3. Load
            {
                Console.Write("What file do you want to load from? (save1.txt)? ");
                journal.LoadFromFile(Console.ReadLine());
            }

            else if (action == 4)//4. save
            {
                Console.Write("What file do you want to save to? (save1.txt)? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                journal.ClearList();
            }

            else if (action == 5)//quit 5
            {
                Console.WriteLine("\n---GoodBye!---");
            }

            else
            {
                Console.WriteLine($"Error! '{action}' is NOT a valid option! Please enter a number 1-5 .");
            }
        }
    }
}
 
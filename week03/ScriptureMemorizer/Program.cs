// To show creativity I made it only select words to hide which arn't already hidden.
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the ScriptureMemorizer Project!\n -Welcome!");
        string book = "Jacob";
        int chapter = 6;
        int firstReference = 11;
        int secondReference = 12;
        string firstVerse = "O then my beloved bretheen, repent ye, and enter in at the strait gate, and continue in the way which is narrow, until ye shall obtain eternal life. O be wise; what can I say more?";

        Reference r1 = new Reference(book, chapter, firstReference);
        Reference r2 = new Reference(book, chapter, firstReference, secondReference);
        // Console.WriteLine(r1.GetDisplayText());
        // Console.WriteLine(r2.GetDisplayText());

        Scripture s1 = new Scripture(r2, firstVerse);

        string userInput = "notQuit";
        while (userInput != "quit")
        {
            Console.Write("\nPress ENTER to continue or type 'quit' to exit. ");
            userInput = Console.ReadLine();
            if (s1.IsCompletelyHidden() == true)
            {
                userInput = "quit";
            }
            Console.WriteLine(s1.GetDisplayText());
            s1.HideRandomWords();
        }

        if (userInput == "quit")
        {
            Console.WriteLine("Good-Bye! Come again soon! :) ");
        }

    }
}
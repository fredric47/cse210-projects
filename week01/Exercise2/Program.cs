using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your score: ");
        string stringScore = Console.ReadLine();
        int score = int.Parse(stringScore);

        string grade = "error";

        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else if (score < 60)
        {
            grade = "F";
        }
        else
        {
            Console.WriteLine("ERROR! Please Try again and make sure to only enter numbers :)");
        }

        Console.WriteLine($"Your grade is {grade}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations!!! You passes the class!");
        }
        else if (score < 70)
        {
            Console.WriteLine("Sorry it looks like you didn't pass the class. Keep woring hard and you can do it next time");
        }
        else
        {
            Console.WriteLine("ERROR! Something went wrong, please try again");
        }
    }
}
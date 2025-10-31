using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        WelcomeMessage();
        string name = GetName();
        int favNum = FavoriteNumber();
        int squNum = SquareNumber(favNum);
        DisplayResult(squNum, name);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.Write("What is your user name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int FavoriteNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(int number, string name)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {number}");
    }

}
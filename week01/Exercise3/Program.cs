using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 100);

        // Console.Write("What is the magic number? ");
        // string stringNumber = Console.ReadLine();


        Console.WriteLine($"magic number is {mNumber}");


        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Console.Write("Guess the number: ");
            string gStringNumber = Console.ReadLine();
            int gussedNumber = int.Parse(gStringNumber);

            if (gussedNumber == mNumber)
            {
                Console.WriteLine("You gussed the number!");
                break;
            }

            else if (gussedNumber > mNumber)
            {
                Console.WriteLine("guess lower");
            }

            else if (gussedNumber < mNumber)
            {
                Console.WriteLine("guess higher");
            }

            else
            {
                Console.WriteLine("ERROR!");
            }
        }
        // Console.WriteLine("Do you want to play again? (yes/no) ");
        // playAgain = Console.ReadLine();
    }
}
 
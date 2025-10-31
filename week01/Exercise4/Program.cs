using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numberList = new List<int>();
        
        int sum = 0;
        int average = 0;
        int largest = 0;
        int numberCount = 0;

        int exit = 0;
        do
        {
            Console.Write("Enter a number to add to the list. Enter 0 when done: ");
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);
            if (number != 0)
            {
                numberList.Add(number);
                numberCount += 1;
                sum += number;
                average = sum / numberCount;
                if (number > largest)
                {
                    largest = number;
                }
            }
            exit = number;
        } while (exit != 0);

        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}
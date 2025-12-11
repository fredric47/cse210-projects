using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    GoalManager gm1 = new GoalManager();
    static void Main(string[] args)
    {
        GoalManager gm1 = new GoalManager();

        string userSelection = "0";
        while (userSelection != "6")
        {
            Console.Write("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\nSelect an option: ");
            userSelection = Console.ReadLine();

            if (userSelection == "1")//creare new goal
            {
                gm1.CreateGoal();
            }

            else if (userSelection == "2")//list goals
            {

            }

            else if (userSelection == "3")//save goals
            {

            }

            else if (userSelection == "4")//load goals
            {

            }

            else if (userSelection == "5")//record event
            {

            }

            else if (userSelection == "6")//quit
            {

            }
        }
    }
}
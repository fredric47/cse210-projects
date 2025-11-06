using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "The Boss";
        job1._company = "Mega Tec";
        job1._startYear = "1521";
        job1._endYear = "1776";
        //job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Overseer";
        job2._company = "Micro Tec";
        job2._startYear = "1776";
        job2._endYear = "2025";
        //job2.Display();


        Resume myResume = new Resume();
        myResume._name = "steve";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.Display();
    }



}
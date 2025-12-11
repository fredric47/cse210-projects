using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> ActivityList = new List<Activity>();
        RunningActivity run = new RunningActivity("12/10/25", 25, 7, "Running");
        StationaryBicycleActivity bike = new StationaryBicycleActivity("12/11/25", 30, 20, "Biking");
        SwimmingLapActivity swim = new SwimmingLapActivity("12/12/25", 29, 25, "Swimming");
        ActivityList.Add(run);
        ActivityList.Add(bike);
        ActivityList.Add(swim);

        foreach (Activity activity in ActivityList)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}
using System.Linq.Expressions;

public abstract class Activity
{
    protected string _date;
    protected double _activityLengthMin; // In minutes
    protected string _activityType;

    public Activity(string date, double activityLength, string activityType)
    {
        _date = date;
        _activityLengthMin = activityLength;
        _activityType = activityType;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();//mph


    public abstract double GetPace();//minutes per mile

    //summery, date & activity type, time, distance, speed, pace. //(date, type)distance, speed, pace
    public string GetSummary()
    {
        return $"{_date}, {_activityType} ({_activityLengthMin} min), Distance: {GetDistance():F2} (miles), Speed: {GetSpeed():F2} (mph), Pace: {GetPace():F2} (min per mile)";
    }

}
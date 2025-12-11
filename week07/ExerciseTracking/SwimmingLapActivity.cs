public class SwimmingLapActivity : Activity
{
    private int _numberOfLaps;

    public SwimmingLapActivity(string date, double activityLength, int numberOfLaps, string activityType) : base(date, activityLength, activityType)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _activityLengthMin * 60;
    }
    public override double GetPace()
    {
        return _activityLengthMin / GetDistance();
    }

    //summery, date & activity type, time, distance, speed, pace. //(date, type)distance, speed, pace
    // public override string GetSummary()
    // {
    //     return $"{_date}, {_activityType} ({_activityLengthMin} min), Distance: {GetDistance():F2} (miles), Speed: {GetSpeed():F2} (mph), Pace: {GetPace():F2} (min per mile)";
    // }
}
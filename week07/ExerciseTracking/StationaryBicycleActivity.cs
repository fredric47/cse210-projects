public class StationaryBicycleActivity : Activity
{
    private double _mph;

    public StationaryBicycleActivity(string date, double activityLength, double speed, string activityType) : base(date, activityLength, activityType)
    {
        _mph = speed;
    }

    public override double GetDistance()
    {
        return _activityLengthMin / 60 * _mph;
    }
    public override double GetSpeed()
    {
        return _mph;
    }
    public override double GetPace()
    {
        return _activityLengthMin / GetDistance();
    }

}
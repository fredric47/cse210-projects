public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        //_color = color;
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius); //Used copilot to remind me to use math.pi instead of 3.14159
    }
}
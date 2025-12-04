using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        string color1 = "White";
        double side = 4.1;
        Square square1 = new Square(color1, side);
        //Console.WriteLine($"Area: {square1.GetArea()}\nColor: {square1.GetColor()}");

        string color2 = "Red";
        double length = 21;
        double width = 10;
        Rectangle rectangle1 = new Rectangle(color2, length, width);
        //Console.WriteLine($"\nArea: {rectangle1.GetArea()}\nColor: {rectangle1.GetColor()}");

        string color3 = "Blue";
        double radius = 16;
        Circle circle1 = new Circle(color3, radius);
        //Console.WriteLine($"\nArea: {circle1.GetArea()}\nColor: {circle1.GetColor()}");

        List<Shape> listOfShapes = new List<Shape>();
        listOfShapes.Add(square1);
        listOfShapes.Add(circle1);
        listOfShapes.Add(rectangle1);

        foreach (Shape shape in listOfShapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }


    }
}
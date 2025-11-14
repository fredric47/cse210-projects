using System;
using System.Diagnostics;

class Program
{
  static void Main(string[] args)
  {
    Fraction f1 = new Fraction();
    Console.WriteLine(f1.GetFractionalString());
    Console.WriteLine(f1.GetDecimalValue());

    Fraction f2 = new Fraction(6);
    Console.WriteLine(f2.GetFractionalString());
    Console.WriteLine(f2.GetDecimalValue());

    Fraction f3 = new Fraction(6, 7);
    Console.WriteLine(f3.GetFractionalString());
    Console.WriteLine(f3.GetDecimalValue());
      
        
  }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"String:  {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal:  {fraction1.GetDecimalValue()}");
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"String:  {fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal:  {fraction2.GetDecimalValue()}");
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"String:  {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal:  {fraction3.GetDecimalValue()}");
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"String:  {fraction4.GetFractionString()}");
        Console.WriteLine($"Decimal:  {fraction4.GetDecimalValue()}");
    }
}
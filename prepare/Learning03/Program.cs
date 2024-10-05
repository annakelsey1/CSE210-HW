using System;

class Program
{
    static void Main(string[] args)
    {
    //     Console.WriteLine("Hello Learning03 World!");

        // Fraction fraction1 = new Fraction();      
        // Fraction fraction2 = new Fraction(5);     
        // Fraction fraction3 = new Fraction(3, 4); 

        // Console.WriteLine(fraction1);
        // Console.WriteLine(fraction2);
        // Console.WriteLine(fraction3);   

        Fraction fraction = new Fraction(5, 2);
        // Console.WriteLine($"Top: {fraction.Top}");
        // Console.WriteLine($"Bottom: {fraction.Bottom}");

        // fraction.Top = 3;
        // fraction.Bottom = 7;
        // Console.WriteLine(fraction);

        string fractionString = fraction.GetFractionString();
        double decimalValue = fraction.GetDecimalValue();

        Console.WriteLine($"Fraction: {fractionString}");
        Console.WriteLine($"Decimal: {decimalValue}");
    }

}
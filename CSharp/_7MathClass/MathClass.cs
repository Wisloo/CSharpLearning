using System.Globalization;

namespace _7MathClass;
using System;

public class MathClass
{
    public static void Main(string[] args)
    {
        double variable = 3;

        double power = Math.Pow(variable, 3); // power 
        Console.WriteLine(power);
        double sqrt = Math.Sqrt(177); // squareroot
        Console.WriteLine(sqrt);
        double absVal = Math.Abs(-901); // absolute value
        Console.WriteLine(absVal);
        double roundOff = Math.Round(90.8996, 2); // round off a value
        Console.WriteLine(roundOff);
        double ceilingMethod = Math.Ceiling(90.25); // force round a value up
        Console.WriteLine(ceilingMethod);
        double floorMethod = Math.Floor(70.125); // force round a value down
        Console.WriteLine(floorMethod);
        double maxVal = Math.Max(-90, -78);
        Console.WriteLine(maxVal);
        double minVal = Math.Min(-89, -129);
        Console.WriteLine(minVal);
        
        Console.ReadKey();
    }
}
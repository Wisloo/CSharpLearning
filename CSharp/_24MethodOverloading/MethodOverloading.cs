namespace _24MethodOverloading;
using System;
public class MethodOverloading
{
    public static void Main(string[] args)
    {
        // method overloading = methods share same name, but different parameters
        // name + parameters = signature
        // methods must have a unique signature

        int num1, num2, num3, total;

        Console.WriteLine("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        total = Result(num1, num2);
        Console.WriteLine("Addition of the two numbers: " + total);
        Console.WriteLine("Enter third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        total = Result(num1, num2, num3);
        Console.WriteLine("Multiplication of the three numbers: " + total);
    }

    static int Result(int num1, int num2)
    {
        int total = num1 + num2;
        return total;
    }

    static int Result(int num1, int num2, int num3) // methods can share the same name but they need different parameters
    {
        int total = num1 * num2 * num3;
        return total;
    }
    
}
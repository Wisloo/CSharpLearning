using System.Globalization;
using System.Net.Http.Headers;

namespace _6ArithmeticOperators;
using System;
public class ArithmeticOperators
{
    public static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        // increment
        num1 += num2; // increments num1 by the value of num2 and assigns it to num1

        Console.WriteLine(num1);

        num1++; // increments a variable by one

        Console.WriteLine(num1);
        
        // decrement

        int num3, num4;
        
        Console.WriteLine("Enter third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter fourth number: ");
        num4 = Convert.ToInt32(Console.ReadLine());

        num3 -= num4; // decrements num3 by the value of num4 and assigns it to num3
        Console.WriteLine(num3);
        num3--; // decrements variable by one
        Console.WriteLine(num3);

        int friends = 12;

        friends *= 2; // same as writing friends = friends * 2 and

        Console.WriteLine(friends);

        friends /= 4; // same as writing friends = friends / 4

        Console.WriteLine(friends);

        friends %= 4; // modulus, basically divides a number and takes the remainder of it, if any.

        Console.WriteLine(friends);
        
        Console.ReadKey();
    }
}
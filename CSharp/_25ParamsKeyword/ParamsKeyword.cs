namespace _25ParamsKeyword;
using System;
public class ParamsKeyword
{
    public static void Main(string[] args)
    {
        // params keyword = a method parameter that takes a variable number of arguments.
        // the parameter type must be a single - dimensional array
        // works as an array of objects to shorten method overloading
        
        double total =  CheckOut(3.99, 5.66, 8.77); // you can have the same name variable as long as it is in a different scope.
        Console.WriteLine(total);
    }

    static double CheckOut(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }
}
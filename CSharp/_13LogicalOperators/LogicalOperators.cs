namespace _13LogicalOperators;
using System;
public class LogicalOperators
{
    public static void Main(string[] args)
    {
        // logical operators = can be used to check if more than one condition is true/false
        // && (AND)
        // || (OR)

        double tempOutside;
        Console.WriteLine("What is the temperature outside? (in celsius): ");
        tempOutside = Convert.ToDouble(Console.ReadLine());


        if (tempOutside >= 10 && tempOutside <= 25) // both must be true (AND)
        {
            Console.WriteLine("It's warm outside");
        } else if (tempOutside <= -50 || tempOutside >= 50) // only one must be true to evaluate to true
        {
            Console.WriteLine("Do not go outside!");
        }
    }
}
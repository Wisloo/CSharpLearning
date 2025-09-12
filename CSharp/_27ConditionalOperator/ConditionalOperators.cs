namespace _27ConditionalOperator;
using System;
public class ConditionalOperators
{
    public static void Main(string[] args)
    {
        // conditional operator = used in conditional assignment if a condition is true/false
        // (condition) ? x : y
        
        double temp = 20;
        String message = "";

        if (temp >= 15)
        {
            message = "It's warm outside";
        }
        else if(temp < 15)
        {
            message = "It's cold outside";
        }
        else
        {
            Console.WriteLine("SYBAU!");
        }

        Console.WriteLine(message);

        message = (temp >= 15) ?  "It's warm outside" : "It's cold outside";
        Console.WriteLine(message);
        
        // you can do else if on conditional operators, just add it in between if and else.

    }
}
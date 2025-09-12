namespace _26ExceptionHandling;
using System;
public class ExceptionHandling
{
    public static void Main(string[] args)
    {
        // exception = errors that occur during execution
        // try = try some code that is considered "dangerous"
        // catch = catches and handles exceptions when they occur
        // finally = always executes regardless if exception is caught or not

        double num1, num2, result;
        try
        {
            // surround a code that is dangerous with a try block
            Console.WriteLine("Enter first number to divide: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number to divide: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            result = num1 / num2;

            Console.WriteLine("The result is " + result);
        }
        /* catch (FormatException e) // catch (exception e), the e holds the exception value
        {
            Console.WriteLine("Type numbers only!");
        }
        catch (DivideByZeroException e) // you can only do this while using an integer datatype
        {
            Console.WriteLine("Cannot divide by 0!");
        } */
        catch (Exception e) // an exception that catches all exception error. Although it can handle everything, it is typically not a good practice
        {
            Console.WriteLine("Something went wrong");
        }
        finally // typically use to close any open files, reset anything
        {
            Console.WriteLine("Thanks!");
        }

        Console.ReadKey();
    }
}
namespace _23ReturnKeyword;
using System;
public class ReturnKeyword
{
    public static void Main(string[] args) // main method
    {
        // return = returns data back to the place where a method is called
        double num1, num2, multiplyResult, addResult;
        Console.WriteLine("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        multiplyResult = Multiply(num1, num2); // this is the method below.
        Console.WriteLine("The result when multiplied together is " + multiplyResult);
        addResult = Add(num1, num2);
        Console.WriteLine("The result when added together is " + addResult);

    }
    // basically, a method is a code block that has an intended to perform a specific task
    static double Multiply(double num1, double num2) // when returning, change "void" to the dataType that you want to return.
    { // this method is responsible for multiplying two numbers.
        double multiplyResult = num1 * num2;
        return multiplyResult;
    }

    static double Add(double num1, double num2)
    {
        double addResult = num1 + num2;
        return addResult;
    }
}
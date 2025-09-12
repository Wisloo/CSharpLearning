namespace _19CalculatorProgram;
using System;
public class CalculatorProgram
{
    public static void Main(string[] args)
    {
        String ans;
        do // make sures the code is executed once
        {
            double num1, num2, result = 0;
            char operatorSymbol;
            

            Console.WriteLine("--------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator (+,-,*,/):  ");
            operatorSymbol = Convert.ToChar(Console.ReadLine());


            switch (operatorSymbol)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Not a valid operator!");
                    break;
            }

            Console.WriteLine("The result is " + Math.Round(result, 2));

            Console.WriteLine("Would you like to continue? (Y = yes, N = no) ");
            ans = Console.ReadLine();

            if (ans == "yes")
            {
                ans = "y";
            }
            else
            {
                ans = "n";
            }
        } while (ans == "y"); // executes the code if the user types "y"
        
        Console.WriteLine("Bye");

    }
}
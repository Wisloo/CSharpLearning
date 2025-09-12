namespace _28StringInterpolation;
using System;
public class StringInterpolation
{
    public static void Main(string[] args)
    {
        // string interpolation = allows us to insert variables into a string literal
        // precede a string literal wih $
        // {} are placeholders

        String firstName = "Louis", lastName = "Lapayag";
        int age = 19;

        Console.WriteLine("Hello " + firstName + " " + lastName + "!");
        Console.WriteLine("You are " + age + " years old.");

        Console.WriteLine($"Hello {firstName} {lastName}!");
        Console.WriteLine($"You are {age, -10} years old."); // you can allocate spaces in the variable and placeholder
    }
}
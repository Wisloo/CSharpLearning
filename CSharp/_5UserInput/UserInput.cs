namespace _5UserInput;
using System;
public class UserInput
{
    public static void Main(string[] args)
    {
        String name;
        int age;
        double gpa;
        
        Console.Write("What is your name? ");
        name = Console.ReadLine(); // this will prompt user input
        Console.Write("What is your age? ");
        age = int.Parse(Console.ReadLine()); // parse the string to int
        Console.Write("What is your gpa? ");
        gpa = Convert.ToDouble(Console.ReadLine());
        // in c# you need to parse/convert an input if it is not string so that you can convert it.
        
        Console.WriteLine("Hello " + name + ". You are " + age + " years old");
        Console.WriteLine("Your gpa is " + gpa);
    }
}
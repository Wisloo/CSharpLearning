using System.Globalization;

namespace _11IfStatements;
using System;
public class IfStatements
{
    public static void Main(string[] args)
    {
        // if statement = basic form of decision making
        int age;
        Console.WriteLine("Please enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18) // if this is true
        {
            Console.WriteLine("You are allowed to play video games in moderation. Also, study programming!!!"); // we do this
        }
        else if (age <= 0) // if this is true and the if statement above is false
        {
            Console.WriteLine("You are not alive yet"); // we do this
        }
        else // if both are false
        {
            Console.WriteLine("You are not allowed to play video games. Study programming!!"); // we do this
        }
        
        // note: the order of the if-elseIf-else statements matters

        String name;
        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
        
        name = name.ToLower();
        if (name == "louis")
        {
            Console.WriteLine("You are Myrrh Edrei Pesa Dumawal's lover");
        }
        else
        {
            Console.WriteLine("You are not Myrrh's lover");
        }
    }
}
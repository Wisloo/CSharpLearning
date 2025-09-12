namespace _12Switches;
using System;

public class Switches
{
    public static void Main(string[] args)
    {
        // switch statements are more efficient than if statements especially if there are many if-statements 
        String day;
        Console.Write("What day is it today? ");
        day = Console.ReadLine();
        day = day.ToLower();
        
        // example of how to write a switch statement
        switch(day) // variable of which you are trying to compare
        {
            case "monday":
                Console.WriteLine("Ughhh it's " + day);
                break; // breaks the loop
            case "tuesday":
                Console.WriteLine("Only three more days till friday");
                break;
            case "wednesday":
                Console.WriteLine("It's " + day + " my doods");
                break;
            case "thursday":
                Console.WriteLine("Omg friday is waving!!");
                break;
            case "friday":
                Console.WriteLine("YAYYYYYY it's saturday tomorrow!");
                break;
            case "saturday":
                Console.WriteLine("Enjoy the weekend my doods");
                break;
            case "sunday":
                Console.WriteLine("Glorify God my doods!");
                break;
            default: // default is like the "else" part of an if else statement
                Console.WriteLine("That's not a day my doods");
                break;
        }
    }
}
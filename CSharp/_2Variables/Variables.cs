namespace Variables._2Variables;
using System;
public class Variables
{
    public static void Main(string[] args)
    {
        int age; // declaration
        age = 37; // initialization
        int num = 3789; // declaration and initialization. int only stores whole numbers including negative
        double pi = 3.14; // double is for decimals
        bool isOnline = false; // bool is for true and false value
        char currency = '$'; // char is for symbols or characters
        String name = "Louis Antonio D. Lapayag"; // used for combining different characters
        int yourAgePlusARandomNumber = age + num;
        
        Console.WriteLine(age);
        Console.WriteLine(num);
        Console.WriteLine("Your age plus a random number is " + yourAgePlusARandomNumber);
        Console.Write("The pi value is " + pi);
        Console.WriteLine("Is your friend online? " + isOnline);
        Console.WriteLine("You have " + currency + "1000");
        Console.WriteLine("Hello " + currency + name);
        
        Console.ReadKey();
    }
}

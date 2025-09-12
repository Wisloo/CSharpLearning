namespace _14WhileLoops;
using System;
public class WhileLoop
{
    public static void Main(string[] args)
    {
        // while loop = repeats some code while some condition remains true
        
        String name = "";

        while (name == "") // while(condition)
        { // code block
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }

        Console.WriteLine("Hello " + name);

        int num, i = 1;
        Console.WriteLine("Enter number: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (i <= num)
        {
            Console.Write(i + " ");
            i++; // iteration so that at some point when the loop condition is satisfied it will stop
        }
        
    }
}
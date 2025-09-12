namespace _15ForLoops;
using System;
public class ForLoop
{
    public static void Main(string[] args)
    {
        // for loop = repeats some code a FINITE amount of times
        int i;
        for (i = 0; i < 10; i += 2)
        {
            Console.WriteLine(i);
        }

        for (i = 10; i > 0; i--) // for (initialization; condition; iteration)
        {
            Console.Write(i + ". ");
        }
        
        if (i == 0)
        {
            Console.WriteLine(i + ". Happy New Year!");
        }
    }
}
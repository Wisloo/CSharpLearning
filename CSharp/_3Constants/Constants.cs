namespace _3Constants;
using System;
public class Constants
{
    public static void Main(string[] args)
    {
        // constants = immutable values which are known at compile time(phase when program source code is translated to machine code or byte code)
        // constants do not change for the life of the program

        const double pi = 3.14159; // use const to prevent anything from unexpectedly changing the value of the variable which adds security to the program
        // pi = 420; you cannot use this to change the value of pi because right above, pi is a constant

        Console.WriteLine("The value of pi is " + pi);

        Console.ReadKey();
    }
}
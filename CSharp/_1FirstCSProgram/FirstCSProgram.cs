namespace _1FirstCSProgram;
using System; // namespace so that you don't have to write System.Console.WriteLine(""); everytime

public class FirstCSProgram
{
    static void Main(string[] args)
    {
        Console.Write("Hey \n"); // print in the same line
        Console.WriteLine("Hello World!"); // print in the next line

        // this is a comment
        
        /* this
         is a multiline
         comment */

        Console.WriteLine("\aLouis Antonio D. Lapayag");
        
        /*
         \a bell (alert)
         \b backslash
         \f form feed
         \n new line
         \r carriage return
         \t horizontal tab
         \v vertical tab
         \' single quotation mark
         \" double quotation mark
         \\ backslash
         \? literal question mark
         */

        Console.ReadKey(); // ends a program once we hit a key
    }
}
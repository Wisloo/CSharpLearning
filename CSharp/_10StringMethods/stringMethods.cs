namespace _10StringMethods;
using System;
public class stringMethods
{
    public static void Main(string[] args)
    {
        String name = "Louis Antonio D. Lapayag";

        name = name.ToUpper(); // forces a string to be capitalized
        Console.WriteLine(name);

        name = name.ToLower(); // forces a string to be lower case
        Console.WriteLine(name);

        String phoneNumber = "0918-694-8018";
        phoneNumber = phoneNumber.Replace("-", " "); // replaces the string

        Console.WriteLine(phoneNumber);

        String word = "Chingus ";
        word = word.Insert(8, "lingus"); // inserts a word at a certain index, always remember that computers start at index 0
        Console.WriteLine(word);

        Console.WriteLine(word.Length); // displays the length of a string

        if (word.Length == 14)
        {
            Console.WriteLine("Hello my lover");
        }
        else
        {
            Console.WriteLine("You are not my lover");
        }

        
        String firstName = name.Substring(0, 5); // length refers to the length of the string at the starting index not the whole string
        String lastName = name.Substring(17, 7);

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        
        // if you write let's say for example name._____ it will immediately show you the different methods you can use. that's why dot(.) is really useful
    }
}
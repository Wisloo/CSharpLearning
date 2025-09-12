namespace _21ForEachLoop;
using System;

public class ForEachLoop
{
    public static void Main(string[] args)
    {
        // ForEach loop = a simpler way to iterate over an array, but it's less flexible than a for loop

        String[] bicycles = { "Colnago", "BXT", "Specialized", "Tsunami" };

        for (int i = 0; i < bicycles.Length; i++)
        {
            Console.WriteLine(bicycles[i]);
        }

        foreach (String bicycle in bicycles) // "bicycle" in this is the nickname for accessing the variables in the array "bicycles"
        {
            Console.WriteLine(bicycle);
        }
    }
}
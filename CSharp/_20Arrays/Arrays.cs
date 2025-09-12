namespace _20Arrays;
using System;
public class Arrays
{
    public static void Main(string[] args)
    {
        // array = a variable that can store multiple values. Fixed size

        String[] bicycles = {"Colnago", "Cervelo", "BXT", "Giant", "Trek", "Specialized"}; // just add [] in the data type and then {} enclosing the variables

        Console.WriteLine(bicycles[2]); // to access the elements inside the array
                                        // you will print it like this the [inside] being the index you want to access. note: index starts at 0 but it means the first element
        Console.WriteLine(bicycles[3]);
        Console.WriteLine(bicycles[1]);
        bicycles[3] = "Bianchi"; // changes the variable in the index. Giant is now going to be replaced by Bianchi

        Console.WriteLine(bicycles[3]);

        Console.WriteLine("Bicycles: ");
        for (int i = 0; i < bicycles.Length; i++)
        {
            Console.WriteLine(bicycles[i]); // easier way of displaying all of the elements inside the array. 
                                            // note: i usually means index that's why it's always initialized as 0 because index starts at 0
        }
    }
}
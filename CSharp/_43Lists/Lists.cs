using System.Globalization;

namespace _43Lists;
using System.Collections.Generic;

public class Lists
{
    public static void Main(string[] args)
    {
        // List = a data structure that represents a list of objects that can be accessed by index.
        //        Similar to array, but can dynamically increase/decrease in size
        //        using System.Collections.Generic;

        String[] food = new string[3];

        food[0] = "pizza";
        food[1] = "spaghetti";
        food[2] = "burger"; // normal array, limited and cannot be changed

        foreach (String foods in food)
        {
            Console.WriteLine(foods);
        }
        
        // to create a list you need to "List<DataType> variableName = new List<DataType>
        List<String> cake = new List<String>();
        
        cake.Add("Strawberry Cheesecake");
        cake.Add("Munchkin");
        cake.Add("Sans Rival");
        cake.Add("Red Velvet"); // increase size
        
        foreach (String cakes in cake)
        {
            Console.WriteLine(cakes);
        }

        Console.WriteLine(cake[2]); // accessing a certain index in an array

        cake.Remove("Sans Rival"); // decrease size

        foreach (String cakes in cake)
        {
            Console.WriteLine(cakes);
        }
        
        cake.Insert(2, "Matcha Cake"); // inserting a certain variable into an index
        
        foreach (String cakes in cake)
        {
            Console.WriteLine(cakes);
        }

        Console.WriteLine(cake.Count); // shows the size of the array in elements
        Console.WriteLine(cake.IndexOf("Strawberry Cheesecake")); // pinpoints the index location of a variable
        Console.WriteLine(cake.LastIndexOf("Matcha Cake")); // shows the last index location of a variable
        Console.WriteLine(cake.Contains("Red Velvet")); // this will return true/false depending if the variable is in the array or not 
        cake.Sort(); // sorts the array in alphabetical order
        foreach (String cakes in cake)
        {
            Console.WriteLine(cakes);   
        }
        
        cake.Reverse(); // reverse sorts the array
        Console.WriteLine("Sorted Reverse: ");
        foreach (String cakes in cake)
        {
            Console.WriteLine(cakes);   
        }
        
        String[] cakeArray = cake.ToArray(); // converts the list into array
        foreach (String cakes in cakeArray)
        {
            Console.WriteLine(cakes);   
        }
        cake.Clear(); // clears/empties the array

        
    }
}
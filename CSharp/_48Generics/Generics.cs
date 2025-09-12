namespace _48Generics;

public class Generics
{
    public static void Main(string[] args)
    {
        // generic = "not specific to a particular data type"
        //           add <T> to: classes, methods, fields, etc.
        //           allows code reusability for different data types

        int[] intArray = { 100, 90, 70, 60, 50, 40 };
        double[] doubleArray = { 3.15, 9.75, 63.71, 100.87, 92.81 };
        String[] stringArray = { "Pizza", "Burger", "Fries", "Hotdog" };
        
        displayElements(intArray);
        displayElements(doubleArray);
        displayElements(stringArray);
    }

    public static void displayElements<T>(T[] array) // add <any name here> after the method and inside the parameter
    {
        foreach (T item in array) 
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}
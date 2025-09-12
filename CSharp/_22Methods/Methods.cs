namespace _22Methods;
using System;
public class Methods
{
    public static void Main(string[] args) // this is the main method
    {
        // method = performs a section of code whenever it's called or "invoked"
        // benefit = it let us reuse code w/o writing the code multiple times
        String name = "Louis Lapayag", bicycle = "Colnago"; // you declare the variable before calling the method
        int age = 19;
        tadejPogacarVsJonasVingeegard(name, age); // you are essentially calling the method below, and you are also passing an argument(variables) to it
        bicycleBrands(bicycle); // call the method below and write the argument inside the parameter you want to pass on the method below
    }
    
    static void tadejPogacarVsJonasVingeegard(String greatCyclist, int yearsOld) // you don't have to always rename the variables the same, what's important is the order of the data 
                                                                            // tadejPogacarVsJonasVingeegard(name, age); name = greatCyclist, age = yearsOld
    { // this is a method, usually you place methods outside the main method
        Console.WriteLine("Tadej Pogacar wins!");
        Console.WriteLine("Jonas Vingeegard is a strong time trialist");
        Console.WriteLine("Hello " + greatCyclist); /* methods don't have access to variables within another method so we need to pass
                                            what are known as arguments (arguments = what is sent to methods)*/
        Console.WriteLine("Your age is " + yearsOld + " and you are going to be a strong cyclist just like Pogacar and Vingeegard");

    }

    static void bicycleBrands(String bicycleBrand)
    {
        Console.WriteLine("the BXT brand is so amazing and a great fixie maker!");
        Console.WriteLine(bicycleBrand + " is a great brand for road bikes");
    }
}
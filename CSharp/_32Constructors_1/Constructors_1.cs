namespace _32._1Constructors;
using System;
public class Constructors_1
{
    public static void Main(string[] args)
    {
        Car ToyotaVios2025 = new Car("Toyota", "Vios", "Pink", 2025); // instantiating a car object
        Bicycle Specialize = new Bicycle("Specialize", "Road Bike", "Radioactive Blue", 2007); // instantiating a bicycle object
        
        ToyotaVios2025.Drive();
        Specialize.Ride();
    }

    class Car // note the importance of placing your code block in a scope
    {
        public String make, model, color;
        public int year;

        public Car(String make, String model, String color, int year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model} {color} {year}");
        }
    }
    class Bicycle
    {
        // constructor
        public String make, model, color;
        public int year;
            
        public Bicycle(String make, String model, String color, int year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }

        public void Ride()
        {
            Console.WriteLine($"You are riding the {make} {model} {color} {year}");
        }
    }
}
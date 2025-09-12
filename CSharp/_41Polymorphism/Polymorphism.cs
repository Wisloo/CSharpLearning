namespace _41Polymorphism;

public class Polymorphism
{
    public static void Main(string[] args)
    {
        // polymorphism = Greek word that means "Have many forms"
        //                Objects can be identified into more than one type
        //                Ex. A Dog is also a canine, animal, organism
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        Vehicle[] vehicles = {car, bicycle, boat}; // array of vehicles
        // since these three objects inherit from vehicle we can name the array as Vehicle[]
        // which means that an object can be identified into more than one type
        // if you are going to create an array of objects then you have to find what is common with them

        foreach (Vehicle vehicle in vehicles) // array datatype "Vehicle vehicle"
        {
            vehicle.Go(); 
        }
    }

    class Vehicle
    {
        public virtual void Go() // to allow the method to be overridden
        {
            Console.WriteLine("The car is moving");
        }
    }
    class Car : Vehicle // Car inherits from Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    } 
    class Bicycle : Vehicle // Bicycle inherits from Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }
    class Boat : Vehicle // Boat inherits from Vehicle
    {
        public override void Go() // overriding the Go method from the parent class "Vehicle"
        {
            Console.WriteLine("The boat is moving");
        }
    }
}
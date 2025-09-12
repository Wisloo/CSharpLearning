namespace _36AbstractClasses;

public class AbstractClasses
{
    public static void Main(string[] args)
    {
        // abstract classes = modifier that indicates missing components or incomplete implementation
        Car car = new Car(); // instantiate new object
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        // Vehicle vehicle = new Vehicle(); vehicle is incomplete since it doesn't have variable "wheels"
        
        Console.WriteLine(Car.speed);
        Console.WriteLine(Car.wheels);
        Car.go();
        
        Console.WriteLine(Bicycle.speed);
        Console.WriteLine(Bicycle.wheels);
        Bicycle.go();
        
        Console.WriteLine(Boat.speed);
        Console.WriteLine(Boat.wheels);
        Boat.go();
    }

    abstract class Vehicle // you cannot instantiate the vehicle class
    {
        public static int speed = 0;

        public static void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle // Car has access to Vehicle method
    {
        public static int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public static int wheels = 2;
    }
    class Boat : Vehicle
    {
        public static int wheels = 0;
    }
}
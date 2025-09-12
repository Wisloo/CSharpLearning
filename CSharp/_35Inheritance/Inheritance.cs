namespace _35Inheritance;

public class Inheritance
{
    public static void Main(string[] args)
    {
        // inheritance = 1 or more child classes receiving fields, methods, etc. from a common parent
        Car car = new Car(); // instantiate new object
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        
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

    class Vehicle
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
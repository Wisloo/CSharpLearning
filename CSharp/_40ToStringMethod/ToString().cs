namespace _40ToStringMethod;

public class ToString__
{
    public static void Main(string[] args)
    {
        // ToString() = converts an object to its string representation so that it is suitable for display

        Car car = new Car("Toyota", "Raize", "Black", 2018);

        Console.WriteLine(car);
    }

    class Car
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
            Console.WriteLine($"You are driving a {year} {color} {make} {model}");
        }

        public override string ToString()
        {
            return "This is a " + make + " " + model; // this is an example of ToString()
        }
        
    }
}
namespace _45AutoImplementedProperties;

public class AutoImplementedProperties
{
    public static void Main(string[] args)
    {
        // Auto-Implemented properties = shortcut when no additional logic is required in the property
        //                               you do not have to define a field for a property,
        //                               you only have to write get; and/or set; inside the property
        Car car = new Car("Ford");
        Console.WriteLine(car.Model);
    }

    class Car
    {   
        /* String model;

        public String Model // property
        {
            get { return model; }
            set { model = value; }
        } */

        public String Model { get; set; } // shortcut for properties with no additional logic needed.
        public Car(String model) // constructor
        {
            this.Model = model;
        }
    }
}
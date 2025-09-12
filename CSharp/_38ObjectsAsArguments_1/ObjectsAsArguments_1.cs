namespace _38ObjectsAsArguments_1;

public class ObjectsAsArguments_1
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Mustang", "Pink");
        Car car2 = Copy(car1); // copy object
        
        Console.WriteLine(car2.color + " " + car2.model);
    }

    public static Car Copy(Car car) // method for copying
    {
        return new Car(car.model, car.color);
    }
    
    public class Car
    {
        public String model, color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
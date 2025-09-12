namespace _38ObjectsAsArguments;

public class ObjectsAsArguments
{
    public static void Main(string[] args)
    {
        
        Car car1 = new Car("Lamborghini", "Silver"); // original object and argument
        ChangeColor(car1, "Gold"); // changed argument
        ChangeModel(car1, "Ferrari"); // changed argument

        Console.WriteLine(car1.color + " " + car1.model);
    }

    public static void ChangeColor(Car car, String color) // object as argument
    {
        car.color = color;
    }
    public static void ChangeModel(Car car, String model) // object as argument. Make sure you have the right parameter setup. 
    /* you type the data type of the object (Car) and then followed by the name of the parameter (ex. car)
     then when you invoke/call the method you have to pass in the name of the object*/
    {
        car.model = model;
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
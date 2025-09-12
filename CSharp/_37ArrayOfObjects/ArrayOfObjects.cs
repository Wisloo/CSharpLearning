namespace _37ArrayOfObjects;

public class ArrayOfObjects
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("Honda Civic");
        Car car2 = new Car("Toyota Fortuner");
        Car car3 = new Car("Toyota Avanza");

        Car[] garage = { car1, car2, car3 };

        for (int i = 0; i < garage.Length; i++)
        {
            Console.WriteLine(garage[i].model);
        }



    }

    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
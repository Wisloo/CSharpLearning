namespace _33Static;

public class Static
{
    public static void Main(string[] args)
    {
        // static = modifier to declare a static member, which belongs to the class itself rather than to any specific object

        Cars car1 = new Cars("Mustang"); // this is shared in "Cars" basically they are shared in one variable
        Cars car2 = new Cars("Corvette"); // this is also shared
        Cars car3 = new Cars("Lambo"); // these are all owned by one variable named "numberOfCars"
        Cars car4 = new Cars("Ferrari"); 

        /* Console.WriteLine(car1.numberOfCars);
        Console.WriteLine(car2.numberOfCars); */ // you cannot access this is a non static way as we already declared numberOfCars ina static way

        Console.WriteLine(Cars.numberOfCars);
        Cars.StartRace(); // invoke it
    }

    class Cars // take note that you cannot create an object on a static class
    {
        String model;
        public static int numberOfCars; // by preceding this field with a static modifier, the class already owns it

        public Cars(String model) // constructor
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
    
}
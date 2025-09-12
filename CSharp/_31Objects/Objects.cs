namespace _31Objects;

public class Objects
{
    public static void Main(string[] args)
    {
        // object = an instance of a class
        // a class can be used as a blueprint to create objects (OOP)
        // objects can have fields & methods (characteristics & actions)

        Human human1 = new Human(); // this is an object
        Human Dei = new Human();
        
        human1.name = "Louis";
        human1.age = 19;
        Dei.name = "Myrrh";
        Dei.age = 22;
        
        human1.Eat();
        human1.Sleep();
        
        Dei.Eat();
        Dei.Sleep();
    }

    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
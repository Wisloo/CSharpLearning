namespace _32Constructors;

public class Constructors
{
    public static void Main(string[] args)
    {
        // constructors = a special method found in class
        // Same name as the class name
        // can be used to assign arguments to fields when creating an object
        
        Human human1 = new Human("Louis", 19, isEmployed: false); // you can assign the arguments here and no need to re assign it after
        Human Dei = new Human("Dei", 22, isEmployed: true);
        
        /* human1.name = "Louis";
        human1.age = 19;
        Dei.name = "Myrrh";
        Dei.age = 22; */ // you don't need to do this anymore
        
        human1.Eat();
        human1.Sleep();
        human1.Age();
        human1.IsEmployed();
        
        Dei.Eat();
        Dei.Sleep();
        Dei.Age();
        Dei.IsEmployed();
    }

    class Human
    {
        
        public String name;
        public int age;
        public bool isEmployed = true;
        

        public Human(String name, int age, bool isEmployed)
        {
            this.name = name;
            this.age = age;     // as long as you do this
            this.isEmployed = isEmployed;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }

        public void Age()
        {
            Console.WriteLine(age + " years old");
        }

        public void IsEmployed()
        {
            Console.WriteLine("Employed? " + isEmployed);
        }
    }
}
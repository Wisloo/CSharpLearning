namespace _42Interfaces;

public class Interfaces
{
    public static void Main(string[] args)
    {
        // interface = defines a "contract" all the classes inheriting from should follow
        // an interface declares "what a class should have"
        // an inheriting class defines "how it should do it"
        // benefit = security + multiple inheritance + "plug-and-play"
        
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new  Hawk();
        Fish fish = new Fish();
        
        rabbit.Flee(); // to use most methods you need objects
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();
    }

    interface IPrey // common naming convention of interfaces is that the word preceeds with an I
    { 
        void Flee(); // implement but not declare
    }
    interface IPredator
    {
        void Hunt(); // method implemented but not declared
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away");
        }
    }
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk hunts its prey");
        }
    }

    class Fish : IPrey, IPredator // to have two inherited methods you need to separate it with a comma (,)

    {
        public void Flee()
        {
            Console.WriteLine("The fish flops away");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish hunts for its prey");
        }
    }
}

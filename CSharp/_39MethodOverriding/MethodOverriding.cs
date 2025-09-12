namespace _39MethodOverriding;

public class MethodOverriding
{
    public static void Main(string[] args)
    {
        // method overriding = provides a new version of a method inherited from a parent class
        //                     inherited method must be: abstract, virtual, or already overriden
        //                     Used with ToString(), polymorphism
        Dog dog = new Dog();
        Cat cat = new Cat();
        Shandy shandy = new Shandy();
        
        dog.Speak();
        cat.Speak();
        shandy.Speak();
    }

    class Animal
    {
        public virtual void Speak() // to override a method, the method being overriden must be virtual, abstract, or overridden
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal // inheritance
    {
        public override void Speak()
        {
            Console.WriteLine("The animal goes *arfffff*");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The animal goes *meowwwww*");
        }
    }

    class Shandy : Animal
    {
        
    }
}
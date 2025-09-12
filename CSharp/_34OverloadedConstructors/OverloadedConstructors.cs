namespace _34OverloadedConstructors;
using System;
public class OverloadedConstructors
{
    public static void Main(string[] args)
    {
        // overloaded constructors = technique to create multiple constructors
        // with a different set of parameters
        // name + parameters = signature
        Pizza pizza = new Pizza("Crunchy crust", "Tomato sauce", "Mozzarella", "Peperoni"); // what if we want to only have 3 arguments?
        Pizza plainCheesePizza = new Pizza("Crunchy Crust", "Pizza Overload Sauce", "Mozzarella");
        
        pizza.Eat();
        plainCheesePizza.Eat();
    }
    

    class Pizza
    {
        String bread, sauce, cheese, topping;
        
        public Pizza(String bread, String sauce, String cheese) // constructor overloading, you can have the same name constructor but different arguments
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
        public void Eat()
        {
            Console.WriteLine($"You are eating {bread} {sauce} {cheese} {topping} pizza" );
        }
    }
}
using System.Security.Principal;

namespace ShoppingCartProgram;

public class ShoppingCartProgram
{
    public static void Main(string[] args)
    {
        double price, total, discount, finalTotal;
        bool isRunning = true;
        int choice = 0, index = 0;
        List<double> cart = new List<double>();

        Console.WriteLine("==================================");
        Console.WriteLine("Welcome to Louis Shopping Center!");
        Console.WriteLine("==================================");

        while (isRunning)
        {
            Console.WriteLine("1 = Add Item(Amount)\n2 = Remove Item\n3 = View Cart\n4 = View Total\n5 = Apply Discount\n6 = Exit ");
            Console.WriteLine("==================================");
            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    Console.Write("Enter price of item: ");
                    price = Convert.ToDouble(Console.ReadLine());
                    AddItem(cart, price);
                    Console.WriteLine("==================================");
                    break;
                }
                case 2:
                {
                    Console.Write("Enter index of item to remove: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    RemoveItem(cart, index);
                    Console.WriteLine("==================================");
                    break;
                }
                case 3:
                {
                    ViewCart(cart);
                    Console.WriteLine("==================================");
                    break;
                }
                case 4:
                {
                    total = CalculateTotal(cart);
                    Console.WriteLine($"Total: ${total} ");
                    Console.WriteLine("==================================");
                    break;
                    
                }
                case 5:
                {
                    Console.Write("Enter discount percent: ");
                    discount = Convert.ToDouble(Console.ReadLine());
                    total = CalculateTotal(cart);
                    finalTotal = ApplyDiscount(total, discount); // discount will become discountPercent, doesn't matter the name as long as the order is correct in parameter
                    Console.WriteLine($"Your final total is: {finalTotal} ");
                    Console.WriteLine("==================================");
                    break;
                    
                }
                case 6:
                {
                    Console.WriteLine("Thank you for shopping!s");
                    isRunning = false;
                    break;
                }
                default:
                {
                    Console.WriteLine("Not a valid choice");
                    break;
                }
            }
        } // end of while loop

        
    }

    static void AddItem(List<double> cart, double price)
    {
        cart.Add(price); // adds price to cart
    }

    static void RemoveItem(List<double> cart, int index)
    {
        cart.RemoveAt(index); // removes prices from the cart
    }

    static double CalculateTotal(List<double> cart)
    {
        double sum = 0;
        foreach(double item in cart)
        {
            sum += item;
        }

        return sum;
    }

    static double ApplyDiscount(double total, double discountPercent)
    {
        double discountAmount = total * (discountPercent / 100);
        return total - discountAmount;
    }

    static void ViewCart(List<double> cart)
    {
        if (cart.Count == 0) // compares the cart elements, and if they are 0 then it is empty
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine(i + ". $ " + cart[i]);
            }
        }
    }
}
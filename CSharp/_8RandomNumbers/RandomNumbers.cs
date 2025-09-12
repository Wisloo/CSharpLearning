namespace _8RandomNumbers;
using System;
public class RandomNumbers
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        int diceValue = random.Next(1,7); // in using the random object, the first number is inclusive while the second is exclusive
        Console.WriteLine("The rolled dice is " + diceValue);
        int flipCoin = random.Next(1, 3);

        if (flipCoin == 1)
        {
            Console.WriteLine("Heads!");
        }
        else
        {
            Console.WriteLine("Tails!");
        }
        
    }
}
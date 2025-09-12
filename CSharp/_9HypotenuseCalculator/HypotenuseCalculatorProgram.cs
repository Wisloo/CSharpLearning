namespace _9HypotentuseCalculatorProgram;
using System;
public class HypotenuseCalculatorProgram
{
    public static void Main(string[] args)
    {
        double opp, adj,pythagoreanTheorem, hyp;

        Console.Write("Enter the length of the opposite side: ");
        opp = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of the adjacent side: ");
        adj = Convert.ToDouble(Console.ReadLine());

        pythagoreanTheorem = Math.Sqrt(Math.Pow(opp,2) + Math.Pow(adj, 2));
        hyp= Math.Round(pythagoreanTheorem, 2);
        
        Console.WriteLine("The hypotenuse length is " + hyp);
        
        Console.ReadKey();
    }
}
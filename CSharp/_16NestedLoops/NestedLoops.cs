namespace _16NestedLoops;

public class NestedLoops
{
    public static void Main(string[] args)
    {
        /* nested loops = loops inside of other loops
                        uses vary. used a lot in sorting algorithms
         */
        Console.WriteLine("How many rows? ");
        int rows = Convert.ToInt32(Console.ReadLine()); // outer loop for rows
        
        Console.WriteLine("How many columns? ");
        int columns = Convert.ToInt32(Console.ReadLine()); // inner loop for columns
        
        Console.WriteLine("What symbol should we use? ");
        String symbol = Console.ReadLine();

        for (int i = 0; i < rows; i++) // in order to complete one iteration of the inner for loop
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(symbol); // we have to complete the inner for loop
            }
            Console.WriteLine();
        }
    }
}
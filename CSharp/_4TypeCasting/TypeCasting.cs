namespace _4TypeCasting;
using System;
public class TypeCasting
{
    public static void Main(string[] args)
    {
        /* type casting = converting a value to a different data type
         useful when we accept user input (string)
         different data types can do different things */
        
        // to convert you do Convert.ToDataTypeYouWantToConvert(variableYouWantToConvert);
        
        double height = 7.79;
        int heightButDiff = Convert.ToInt32(height);
        
        Console.WriteLine(height.GetType()); // prints what type of data is the variable
        Console.WriteLine(heightButDiff.GetType()); // prints what type of data is the variable
        Console.WriteLine(heightButDiff);

        int spongeBobBetlogs = 32;
        bool patrickBetlogs = Convert.ToBoolean(spongeBobBetlogs);
        double squidwardBetlogs = Convert.ToDouble(patrickBetlogs) + 0.123;

        String symbol = "&";
        char ch = Convert.ToChar(symbol);

        String isEmployed = "True";
        bool jobApplication = Convert.ToBoolean(isEmployed);
        
        Console.WriteLine(patrickBetlogs);
        Console.WriteLine(squidwardBetlogs);
        Console.WriteLine(ch);
        Console.WriteLine(jobApplication);
        Console.WriteLine(jobApplication.GetType());
        
        Console.ReadKey();
    }
}
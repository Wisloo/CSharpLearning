using System.Xml;

namespace _29MultiDimensionalArrays;
using System;
public class MultiDimensionalArrays
{
    public static void Main(string[] args)
    {
        // multi-dimensional arrays are good if you want to create some sort of grid or matrix data

        String[] ford = { "Mustang", "F-150", "Explorer" };
        String[] chevy = { "Corvette", "Camaro", "Silverado" };
        String[] toyota = { "Corolla", "Vios", "Wigo" };

        String[,] parkingLot =
        {
            { "Mustang", "F-150", "Explorer" }, // row 0
            { "Corvette", "Camaro", "Silverado" }, // row 1
            { "Corolla", "Vios", "Wigo" } // row 2
        };

        parkingLot[1, 2] = "Chingusrado";
        parkingLot[2, 1] = "Cervelo is the best bike manufacturer ever";
        /*
        foreach (String cars in parkingLot)
        {
            Console.WriteLine(cars);
        } */
        // printing the data in a grid like matrix
        for (int i = 0; i < parkingLot.GetLength(0); i++)
        {
            for (int j = 0; j < parkingLot.GetLength(1); j++)
            {
                Console.Write("{" + parkingLot[i,j] + "}" + " ");
            }
            Console.WriteLine();
        }
    }
}
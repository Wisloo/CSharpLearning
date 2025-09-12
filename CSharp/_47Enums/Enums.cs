namespace _47Enums;

public class Enums
{
    public static void Main(string[] args)
    {
        // enums = special "class" that contains a set of name d integer constants.
        //         use enums when you have values that you know will not change,
        //         To get the integer value from an item, you must explicitly convert to an int
        //         name = integer

        Console.WriteLine(Planets.Uranus + " is a great planet");
        Console.WriteLine(Planets.Earth + " is planet #" + (int)Planets.Earth); // precede with "int" if you want to access the associated number on the enum
        Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury); // precede with "int" if you want to access the associated number on the enum
        Console.WriteLine(Planets.Venus + " is planet #" + (int)Planets.Venus); // precede with "int" if you want to access the associated number on the enum

        String Earth = PlanetRadius.Earth.ToString();
        int EarthRadius = (int)PlanetRadius.Earth;
        double volume = Volume(PlanetRadius.Earth);
        
        Console.WriteLine("Planet Radius of " + Earth + " is " + EarthRadius + " km");
        Console.WriteLine("Planet Volume of " + Earth + " is " + volume + " km^3");
        
    }

    public static double Volume(PlanetRadius radius)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        return volume;
    }

    enum Planets // index is 0 by default and enums use index
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7, 
        Neptune = 8
    }

    public enum PlanetRadius // public so that it can be accessed on the method "Volume"
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362, 
        Neptune = 24622
    }
}
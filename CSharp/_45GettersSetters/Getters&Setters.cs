namespace _45GettersSetters;

public class Getters_Setters
{
    public static void Main(string[] args)
    {
        // getters & setters = add security to the fields by encapsulation
        //                     They're accessors found within properties
        // properties = combine aspects of both fields and methods (share name with a field)
        // get accessor = used to return the property value
        // set accessor = used to assign a new value
        // value keyword = defines the value being assigned by the set (parameter)

        Car car = new Car(40);
        car.Speed = 1000000; // you can only access this through the property Speed not speed even though it is the name of the variable

    }

    class Car
    {
        private int speed; // name of the variable

        public Car(int speed)
        {
            Speed = speed; // assign the property "Speed" in the constructor
        }

        public int Speed // property
        {
            get {return speed;} // readable
            
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
                
            } // writable

        }
    }
    
}
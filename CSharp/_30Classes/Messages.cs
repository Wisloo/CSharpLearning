namespace _30Classes 
{
    static class Messages // to access a class you can either create an object from the main class or precede it with static followed within the class
    {
        public static void Hello() // to make it accessible from anywhere you can precede it with "public" 
        {
            Console.WriteLine("Hello, welcome to the program!");
        }

        public static void Waiting()
        {
            Console.WriteLine("Please wait for the program to load");
        }

        public static void Bye()
        {
            Console.WriteLine("Bye! thanks for visiting");
        }
    }
}

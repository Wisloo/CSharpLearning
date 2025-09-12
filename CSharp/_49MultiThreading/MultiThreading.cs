namespace _49MultiThreading;
using System.Threading;
public class MultiThreading
{
    public static void Main(string[] args)
    {
        // thread = an execution in path of a program
        //          we can use multiple threads to perform,
        //          different tasks of our program at the same time.
        //          current thread running is "main" thread
        //          using System.Threading;
        // note: since both are running, we cannot guarantee that even if we start a code block earlier it will be the first to start since we are multithreading
        
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread";
        // Console.WriteLine(mainThread.Name);
        Thread thread1 = new Thread(() => CountDown("Timer #1")); // if ever you have parameters setup in the method
        Thread thread2 = new Thread(CountUp);
        
        thread1.Start(); // both of these are in different threads so they will be able to start separately
        thread2.Start();
        
        /* CountDown(); // this will be running on the same thread so if the first invoked method is not done then the second method will not start
        CountUp(); */
        
        Console.WriteLine(mainThread.Name + " is complete");
    }

    public static void CountDown(String name)
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine("Timer #1 : " + i + " seconds");
            Thread.Sleep(1000); // this is a timer in milliseconds that will be used in invoking the method
        }
        Console.WriteLine("Timer # 1 is complete!");
    }

    public static void CountUp()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Timer #2 : " + i + " seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Timer # 2 is complete!");
    }
    
}
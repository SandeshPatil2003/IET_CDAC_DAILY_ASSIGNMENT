namespace Thread1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PART 1: The Main Thread
            // Every application starts with one thread. By default, it has no name.
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "PrimaryThread";
            Console.WriteLine($"Current Thread ID: {mainThread.ManagedThreadId}, Name: {mainThread.Name}");

            // PART 2: Creating and Starting Threads
            // Using ThreadStart delegate to run methods concurrently.
            Thread t1 = new Thread(Method1) { Name = "Worker_1" };
            Thread t2 = new Thread(Method2) { Name = "Worker_2" };

            // t1.Start(); 
            // t2.Start();

            // PART 3: Thread Synchronization (Join & IsAlive)
            // This section demonstrates how the Main thread waits for background tasks.
            Console.WriteLine("\n--- Starting Lifecycle Demo ---");

            Thread t5 = new Thread(F1);
            Thread t6 = new Thread(F2);

            t5.Start();
            t6.Start();

            // Join(ms) blocks the Main thread for a specific time.
            // F1 takes 5000ms. We only wait 2000ms here.
            if (t5.Join(2000))
            {
                Console.WriteLine("F1 finished within the 2-second limit.");
            }
            else
            {
                Console.WriteLine("F1 is taking too long; Main thread moving on...");
            }

            // Join() without parameters waits indefinitely until the thread finishes.
            t6.Join();
            Console.WriteLine("F2 has definitely finished.");

            // Checking the status of a thread without blocking.
            if (t5.IsAlive)
            {
                Console.WriteLine("Status Check: F1 is still running in the background.");
            }

            Console.WriteLine("Main method execution complete.");
        }

        #region Task Methods

        static void F1()
        {
            Console.WriteLine("F1: Starting 5-second task...");
            Thread.Sleep(5000); // Simulate heavy work
            Console.WriteLine("F1: Task Complete.");
        }

        static void F2()
        {
            Console.WriteLine("F2: Quick task completed instantly.");
        }

        static void Method1()
        {
            string? name = Thread.CurrentThread.Name;
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"{name} processing item {i}");
                Thread.Sleep(100);
            }
        }

        static void Method2()
        {
            string? name = Thread.CurrentThread.Name;
            Console.WriteLine($"{name} started a long operation...");
            Thread.Sleep(3000);
            Console.WriteLine($"{name} finished long operation.");
        }

        #endregion
    }
}


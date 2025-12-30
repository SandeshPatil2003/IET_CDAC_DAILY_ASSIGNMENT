using System.Diagnostics;

namespace Thread2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Helper to reset and start timer
            Stopwatch watch = new Stopwatch();

            #region 1. Sequential Execution (Synchronous)
            // Concept: Runs one after another on the Main Thread. 
            // Pros: Simple. Cons: Slowest approach; UI freezes.
            watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                DoSomeThingComplex();
            }
            watch.Stop();
            Console.WriteLine($"[1] Sequential Time: {watch.ElapsedTicks} ticks");
            #endregion

            #region 2. Manual Threading (Thread Class)
            // Concept: Explicitly creates 10 separate OS threads.
            // Pros: Faster than sequential. Cons: High overhead to create/destroy threads.
            watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(DoSomeThingComplex);
                t.Start();
            }
            watch.Stop();
            Console.WriteLine($"[2] Manual Threading Time: {watch.ElapsedTicks} ticks");
            #endregion

            #region 3. TPL - Task-Based Parallelism (Explicit)
            // Concept: Uses the Thread Pool (managed by .NET).
            // Pros: More efficient than 'Thread' class; reuses existing threads.
            watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Task.Run(() => DoSomeThingComplex());
            }
            watch.Stop();
            Console.WriteLine($"[3] Task.Run Time: {watch.ElapsedTicks} ticks");
            #endregion

            #region 4. TPL - Parallel.ForEach (Implicit)
            // Concept: High-level abstraction for looping over data in parallel.
            // Pros: Automatically decides how many threads to use based on CPU cores.
            int[] data = Enumerable.Range(1, 10).ToArray();
            watch.Restart();
            Parallel.ForEach(data, (number) =>
            {
                DoSomeThingComplex();
                Console.WriteLine($"Processing {number} on Thread: {Thread.CurrentThread.ManagedThreadId}");
            });
            watch.Stop();
            Console.WriteLine($"[4] Parallel.ForEach Time: {watch.ElapsedTicks} ticks");
            #endregion

            #region 5. Parallel LINQ (PLINQ)
            // Concept: Using .AsParallel() to run queries across multiple cores.
            List<Employee> employees = GetMockEmployees();

            var filteredResults = employees.AsParallel()
                                          .Where(e => e.Address.StartsWith("N"))
                                          .ToList();

            Console.WriteLine($"\n[5] PLINQ Results (Addresses starting with 'N'):");
            filteredResults.ForEach(e => Console.WriteLine($"- {e.Name} in {e.Address}"));
            #endregion
        }

        public static void DoSomeThingComplex()
        {
            // Simulated CPU-intensive mathematical work
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 1000; j++) { /* Simulate work */ }
            }
        }

        private static List<Employee> GetMockEmployees()
        {
            return new List<Employee>() {
                new Employee{ ID = 1, Name = "Jignesh", Address = "Patna"},
                new Employee{ ID = 2, Name = "Prathamesh", Address = "Nashik"},
                new Employee{ ID = 3, Name = "Devendra", Address = "Nagpur"},
                new Employee{ ID = 4, Name = "Kalpesh", Address = "Kerla"},
                new Employee{ ID = 5, Name = "Kushendra", Address = "Indore"}
            };
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}


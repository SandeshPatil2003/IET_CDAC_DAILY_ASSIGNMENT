namespace LoggingDemo
{
    public sealed class AppLogger
    {


        private static readonly AppLogger _instance = new AppLogger();

        private AppLogger() => Console.WriteLine("[System] Logger initialized ");

        public static AppLogger Instance => _instance; 

        public void Log(string message)
        {
            Console.WriteLine($"---LOG [{DateTime.Now:T}]:{message}");
        }
    }
}
namespace LoggingDemo
{
    public static class DatabaseFactory
    {


        public static Database Create(int choice) => choice switch
        {
            1 => new SQLServer(),
            2 => new MySQL(),
            _ => throw new ArgumentException("Invalid Exception")

        };

    }
}
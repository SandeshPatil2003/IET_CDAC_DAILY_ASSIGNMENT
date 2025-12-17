namespace LoggingDemo
{
    public class SQLServer : Database
    {
        protected override string DbName => "SQL Server";

        protected override void PerformDelete() => Console.WriteLine("SQL Server running Delete");

        protected override void PerformInsert() => Console.WriteLine("SQL Server running Insert");
        
    }
}
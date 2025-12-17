namespace LoggingDemo
{
    public class MySQL : Database
    {
        protected override string DbName => "MySQL Server";

        protected override void PerformDelete() => Console.WriteLine("MySQL running Delete"); 

        protected override void PerformInsert() => Console.WriteLine("MySQL running Insert"); 
        
    }
}
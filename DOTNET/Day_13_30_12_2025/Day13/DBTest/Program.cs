using DBTest.DAL;

namespace DBTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Hello, World!");
            DBContext dBContext = new DBContext();
            dBContext.add();
            Console.WriteLine("Data fetched");
        }
    }
}

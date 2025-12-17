namespace LoggingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dbChoice;

            do
            {
                Console.WriteLine("Select DB 1. SQL , 2.MySQL ,3. Exit ");

                dbChoice = Convert.ToInt32(Console.ReadLine());

                if (dbChoice < 3)
                {

                    Database db = DatabaseFactory.Create(dbChoice);

                    Console.WriteLine("Select Option: 1.Insert 2.Delete");
                    string? option = Console.ReadLine();

                    if (option == "1") db.ExecuteInsert();
                    else if (option == "2") db.ExecuteDelete();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Exiting");
                }

            } while (dbChoice != 3);
        }
    }
}

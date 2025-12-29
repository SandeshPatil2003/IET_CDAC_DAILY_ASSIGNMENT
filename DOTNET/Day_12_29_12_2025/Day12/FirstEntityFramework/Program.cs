using FirstEntityFramework.DAL;
using FirstEntityFramework.Models;

namespace FirstEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use 'using' to ensure the database connection closes automatically
            using IETDbContext _DbContext = new IETDbContext();

            while (true)
            {
                Console.WriteLine("\n--- DB Operations ---");
                Console.WriteLine("1. Select (View All)\n2. Insert (Add)\n3. Update\n4. Delete\n5. Exit");
                Console.Write("Choice: ");

                if (!int.TryParse(Console.ReadLine(), out int opChoice)) continue;

                switch (opChoice)
                {
                    case 1: // SELECT ALL
                        var allEmps = _DbContext.emps.ToList();
                        allEmps.ForEach(e => Console.WriteLine($"[{e.Id}] {e.Name} - {e.Address}"));
                        break;

                    case 2: // INSERT
                        Console.Write("Enter Name: ");
                        string? name = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        string? addr = Console.ReadLine();

                        _DbContext.emps.Add(new Emp { Name = name, Address = addr });
                        _DbContext.SaveChanges(); // Commits to DB
                        Console.WriteLine("Inserted successfully.");
                        break;

                    case 3: // UPDATE
                        Console.Write("Enter ID to Update: ");
                        int updateId = int.Parse(Console.ReadLine() ?? "0");

                        Emp? empToUpdate = _DbContext.emps.Find(updateId);
                        if (empToUpdate != null)
                        {
                            Console.Write("New Name: "); empToUpdate.Name = Console.ReadLine();
                            Console.Write("New Address: "); empToUpdate.Address = Console.ReadLine();
                            _DbContext.SaveChanges();
                            Console.WriteLine("Updated.");
                        }
                        break;

                    case 4: // DELETE
                        Console.Write("Enter ID to Delete: ");
                        int delId = int.Parse(Console.ReadLine() ?? "0");

                        Emp? empToDel = _DbContext.emps.Find(delId);
                        if (empToDel != null)
                        {
                            _DbContext.emps.Remove(empToDel);
                            _DbContext.SaveChanges();
                            Console.WriteLine("Deleted.");
                        }
                        break;

                    case 5: return; // Exit Program
                }

                Console.WriteLine("\nContinue? (y/n): ");
                if (Console.ReadLine()?.ToLower() == "n") break;
            }
        }
    }
}

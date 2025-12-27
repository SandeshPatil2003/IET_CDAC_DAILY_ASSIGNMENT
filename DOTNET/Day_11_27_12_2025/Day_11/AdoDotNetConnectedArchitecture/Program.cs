using AdoDotNetConnectedArchitecture.Service;
using System.Xml.Serialization;

namespace AdoDotNetConnectedArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService us = new UserServiceImpl();
            Console.WriteLine("Welcome");
            int choice = 0;
            do
            {
                Console.WriteLine("1.Register\n 2.Login\n 4.Exit");
                Console.WriteLine("Enter choice :");
                 choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int n = us.registerUser();
                        if (n > 0)
                        {
                            Console.WriteLine("Registration Successfull");
                        }
                        else
                        {
                            Console.WriteLine("Unable to Register");
                        }
                            break;
                    case 2:
                        Console.WriteLine("Enter user name :");
                        string? uname= Console.ReadLine();

                        Console.WriteLine("Enter Password :");
                        string? password = Console.ReadLine();

                        bool status = us.validateUser(uname, password);
                        if (status)
                        {
                            Console.WriteLine($"Welcome {uname}");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid {uname} or {password}");
                        }
                            break;
                    case 4:
                        Console.WriteLine("Thanks for visiting!!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }


            } while (choice != 4);
        }
    }
}

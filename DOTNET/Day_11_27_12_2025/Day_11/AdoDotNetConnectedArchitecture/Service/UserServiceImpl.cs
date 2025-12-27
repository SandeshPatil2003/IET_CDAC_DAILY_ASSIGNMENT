using AdoDotNetConnectedArchitecture.DAL;
using AdoDotNetConnectedArchitecture.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetConnectedArchitecture.Service
{
    internal class UserServiceImpl : UserService
    {
        DBContext dBContext = new DBContext(); 
        public int registerUser()
        {
            Console.WriteLine("Enter Name :");
            string? name= Console.ReadLine();
            Console.WriteLine("Enter Email :");
            string? email = Console.ReadLine();
            Console.WriteLine("Enter Password :");
            string? password = Console.ReadLine();

            User user = new User(name, email, password); 

            return dBContext.registerUser(user);
        }

        public bool validateUser(string? uname, string? password)
        {
            return dBContext.validate(uname,password);
        }
    }
}

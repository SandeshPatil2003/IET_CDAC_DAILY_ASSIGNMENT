using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetConnectedArchitecture.Entity
{
    internal class User
    {
        public User()
        {
        }

        public string? UName { get; set; }

        public string? UEmail { get; set; }

        public string? UPassword { get; set; }

        public string? URole { get; set; }

        public User(string? uName, string? UEmail, string? UPassword, string? uRole)
        {
            UName = uName;
            this.UEmail = UEmail;
            this.UEmail = UPassword;
            URole = uRole;
        }

        public User(string? uName, string? UEmail, string? UPassword)
        {
            UName = uName;
            this.UEmail = UEmail;
            this.UPassword = UPassword;
            URole = "user";
        }

        public override string? ToString()
        {
            return $"Uname : {UName}, UEmail : {UEmail}";
        }
    }
}

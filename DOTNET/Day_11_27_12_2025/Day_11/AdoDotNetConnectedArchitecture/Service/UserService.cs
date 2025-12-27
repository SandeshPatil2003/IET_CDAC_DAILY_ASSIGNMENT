using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetConnectedArchitecture.Service
{
    internal interface UserService
    {
        int registerUser();
        bool validateUser(string? uname, string? password);
    }
}

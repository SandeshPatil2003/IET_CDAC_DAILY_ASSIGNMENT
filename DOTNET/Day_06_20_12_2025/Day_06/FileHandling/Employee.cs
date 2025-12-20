using System.Net;
using System.Xml.Linq;

namespace FileHandling
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private string _role;

        public Employee() { }
        public Employee(int v1, string v2, string v3)
        {
            this._id = v1;
            this._name = v2;
            this._role = v3;
        }

        public override string ToString()
        {
            return $"ID: {_id}, Name: {_name}, Role: {_role}";
        }
    }
}
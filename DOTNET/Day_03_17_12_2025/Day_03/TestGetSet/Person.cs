using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGetSet
{
    public class Person
    {

        public int age { get; set; }

        public string name { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public Person()
        {
        }
    }

    public class Employee : Person
    {
        

        public int empid { get; set; }


        public Employee()
        {
        }

        

        public Employee(int empid)
        {
            this.empid = empid;
        }

        public Employee(int age, string name) : base(age, name)
        {
        }

        builder.Services.Singleton
    }

    #region abc

    #endregion


      

}

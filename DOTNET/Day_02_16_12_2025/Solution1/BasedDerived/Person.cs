using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasedDerived
{
    public class Person
    {
        public int age {  get;  set; }
        public string? fname { get; set; }
        public String? lname { get; set; }


        public Person(int age, string fname, string lname)
        {
            this.age = age;
           this.fname = fname;
            this.lname = lname;
        }

        public Person()
        {
        }
    }


    public class Employee:Person
    {
        public Employee()
        {
        }

        public Employee(int empid, string dept, string role)
        {
            this.empid = empid;
            this.dept = dept;
            this.role = role;
        }

        public Employee(int empid, string dept, string role,int age, string fname, string lname) : base(age, fname, lname)
        {
        }


        public int empid { get; set; }
       public string? dept { get; set; }
       public string? role { get; set; }





     
    }



}

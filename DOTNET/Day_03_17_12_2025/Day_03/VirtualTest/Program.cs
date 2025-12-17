using System.Net.Security;

namespace VirtualTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base1 b = new Base1();
            Derived1 b2 = new Derived1();
            Base1 b3 = new Derived1();

            b.Hello();
            b2.Hello();
            b3.Hello(); 

        }




    }

    public class Base1()
    {
        public void Hello() => Console.WriteLine("Hello");
    }

    public class Derived1() : Base1
    {
        public void Hello() => Console.WriteLine("Hello Derived");
    }

}

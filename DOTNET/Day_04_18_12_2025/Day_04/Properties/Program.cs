namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestClass obj1 = new TestClass();

            obj1.property1 = 1;
            obj1.property2 = "John Cena";

            Console.WriteLine($"{obj1.property1}");
            Console.WriteLine($"{obj1.property2}");

        }
    }
}

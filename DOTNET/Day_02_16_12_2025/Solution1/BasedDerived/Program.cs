namespace BasedDerived
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person p = new Person();

            Person e1 = new Employee();

            Employee e2 = new Employee();

            p.age = 30;
            p.fname = "Test";
            
            

            Console.WriteLine(p.age);
            Console.WriteLine(p.fname);
            Console.WriteLine(p.ToString);


            Console.WriteLine("Enter a number");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number is {0}",num);
            Console.WriteLine($"Number is {num}");
            


        }
    }
}

namespace Delegate
{
    public delegate void Delegate1(int x, int y);
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            CustomMath cmath = new CustomMath();

            Delegate1 del1 = new Delegate1(cmath.Add);
            Delegate1 del2 = new Delegate1(cmath.Sub);
        }

        
    }

    public class CustomMath()
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }


   
}

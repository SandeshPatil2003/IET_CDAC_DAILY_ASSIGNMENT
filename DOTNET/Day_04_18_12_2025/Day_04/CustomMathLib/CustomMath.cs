namespace CustomMathLib
{
    public class CustomMath
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition is {x + y}");
        }

        private void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction is {x - y}");
        }

        protected void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication is {x * y}");
        }

        internal void Div(int x, int y)
        {
            Console.WriteLine($"Division is {x / y}");
        }

        protected internal void Sqr(int x)
        {
            Console.WriteLine($" {x} Squared is {x*x}");
        }
    }
}

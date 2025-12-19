


namespace Generics
{
    internal class CustomMath
    {
        internal T Add<T>(T v1, T v2)
        {
            dynamic a = v1;
            dynamic b = v2;
            return a+b;
        }

        internal void CalcCircle(int v, out double area, out double circumference)
        {
            area = 3.1415 * v * v;
            circumference = 2 * 3.1415 * v;
        }

        internal void PrintAvengers(int id, params string[] names )
        {
            Console.WriteLine($"ID is {id}, Avengers are : {string.Join(", ",names)}");
        }

        internal void Swap(ref int x, ref int y)
        {
            int temp=x; x=y; y=temp;

            
        }
    }
}
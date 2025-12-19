
namespace Generics
{
    internal class GenClass<T>
    {
        internal void What(T v)
        {
            Console.WriteLine($"This is what was there :{v}");
        }
    }
}
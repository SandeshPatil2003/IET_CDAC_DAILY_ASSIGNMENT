namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomMath cmath = new CustomMath();


            int x = 10, y = 30;

            cmath.Swap(ref x, ref y);

            Console.WriteLine($"Swapped : x={x} y={y}");


            Console.WriteLine($"Add result: {cmath.Add(25,26)}");
            Console.WriteLine($"Add strings : {cmath.Add("Hi","World")}");

            cmath.CalcCircle(10, out double area, out double circumference);

            Console.WriteLine($"Circle area: {area} circumference: {circumference}");

            cmath.PrintAvengers(636, "IronMan", "SpiderMan", "Hulk");

            GenClass<string> genreturn1 = new GenClass<string>();
            GenClass<int> genreturn2 = new GenClass<int>();

            genreturn1.What("Strings");
            genreturn2.What(123);

            Avenger av1 = new Avenger("ironman", "la");
            Avenger av2 = new Avenger("spiderman", "ny");


            List<Avenger> hlist = new List<Avenger>();

            hlist.Add(av1);
            hlist.Add(av2);


            Dictionary<int, Avenger> heroDict = new Dictionary<int, Avenger>();

            heroDict.Add(1, av1);
            heroDict.Add(2, av2);

            Console.WriteLine($"Dict Access:  {heroDict[1].Name}, {heroDict[2].Name}, {heroDict[1].City}");
        }
    }
}

namespace GenericDelegate
{

    public delegate void MyDelegate();

    public delegate void MyDelegate2<T>(T para);

    public delegate void MyDelegate3<T1, T2>(T1 para1, T2 para2);

    public delegate bool PredicateDelegate<T>(T para);

    internal class Program
    {



        static void Main(string[] args)
        {

            TestDelegate testd = new TestDelegate();

            MyMath math = new MyMath();


            MyDelegate del1 = testd.SayHi;
            del1();

            MyDelegate2<string> del2 = testd.SayHello;
            del2("John Cena");

            MyDelegate2<int> del3 = testd.Display;
            del3(55);

            MyDelegate3<string, string> del4 = testd.Greet;
            del4("John Cena", "The Rock");

            PredicateDelegate<int> pred1 = testd.CheckEven;
            bool isEven = pred1(121);

            Console.WriteLine($"isEven ={isEven} for number = 121");

            PredicateDelegate<int> pred2 = testd.CheckOdd;

            bool isOdd = pred2(77);
            Console.WriteLine($"isOdd ={isOdd} for number = 77");


            MyDelegate3<string, string> delGreet = testd.Greet;

            math.Test<string, string, string, string>(delGreet, "John Cena", "The Rock");

        










        }
    }
}

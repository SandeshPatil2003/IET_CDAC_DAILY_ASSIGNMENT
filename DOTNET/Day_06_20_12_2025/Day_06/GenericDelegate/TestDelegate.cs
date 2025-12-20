namespace GenericDelegate
{
    internal class TestDelegate
    {

        public void SayHi()
        {
            Console.WriteLine("Hi , There !");
        }


        public void SayHello(string name)
        {
            Console.WriteLine($"Hello , {name}");
        }


        public void Greet(string name, string msg)
        {

            Console.WriteLine($" Greetings {name} , {msg}");

        }

        public void Display(int number)
        {
            Console.WriteLine($"Number is {number}");
        }

        public bool CheckEven(int number)
        {
           return number % 2 == 0;
        }

        public bool CheckOdd(int number)
        {
            return number %2 != 0;
        }

        public int Add(int[] numbers)
        {
            int sum = 0;
            foreach(var num in numbers)
            {
                sum+= num;
            }

            return sum;
        }

        public void Add( int n1 , int n2, int n3 , out int sum)
        {
            sum = n1 + n2 + n3;
        }


    }
}
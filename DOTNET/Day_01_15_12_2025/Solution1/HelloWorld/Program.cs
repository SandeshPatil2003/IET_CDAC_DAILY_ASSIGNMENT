using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Hello, World!");
            // }

            // string word = Console.ReadLine();

            // Console.WriteLine($"Hello {word}, World!");


            // Console.WriteLine("Enter Number to make Factorial for");

            //string input = Console.ReadLine();
            // int num;

            // int.TryParse(input,out num);

            // int fact = 1;
            // for (int i = 1; i <= num; i++)
            // {

            //     fact = fact * i;

            // }



            // Console.WriteLine($"Number is {fact}");


            Console.WriteLine("Enter Number to know if prime");
            string input1 = Console.ReadLine();
            int num1;

            int.TryParse(input1, out num1);

            int flag = 0;

            for (int i = 2; i < (int)Math.Floor(Math.Sqrt(num1)); i++)
            {

                if (num1 % i == 0)
                {
                    flag = 1;
                }
            }

            if (flag == 0 || num1 == 2)
            {
                Console.WriteLine($"Number {num1} is prime");
            }
            else if (flag == 1 || num1 < 2)
            {

                Console.WriteLine($"Number {num1} is  not prime");
            }






        }
        public Boolean isPrime(int num1)
        {
            int flag = 0;

            for (int i = 2; i < (int)Math.Floor(Math.Sqrt(num1)); i++)
            {

                if (num1 % i == 0)
                {
                    flag = 1;
                }
            }

            if (flag == 0 || num1 == 2)
            {
                Console.WriteLine($"Number {num1} is prime");
            }
            else if (flag == 1 || num1 < 2)
            {

                Console.WriteLine($"Number {num1} is  not prime");
            }
        }



    }

}


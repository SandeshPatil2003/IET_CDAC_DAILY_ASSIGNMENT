namespace DiamondPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            int mid = n / 2;


            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    if (Math.Abs(i - mid) + Math.Abs(j - mid) == mid)
                    {
                        Console.Write(" * ");
                    }
                    else {

                        Console.Write("    ");
                     }




                }

                Console.WriteLine();


            }
        }
    }

}

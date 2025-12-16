namespace DiamondPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int num2 = (num/2)+1;
            int num3 = num2;
            for (int j = 0; j <num; j++)
            {
                for (int i = 0; i < num2; i++)
                {

                    Console.Write(" ");
                    num2--;
                   

                }
               
                Console.Write("*");
                for (int k = 0; k < num2; k++)
                {

                    Console.Write(" ");
                    num3--;


                }
                if(j!=(num-1) || j!=0)
                { Console.Write("*"); 
                
                }


                Console.WriteLine(" ");

            }
        }
    }
}

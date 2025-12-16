namespace MenuDrivenConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice;
            do
            {

                Console.WriteLine("1.Add\n 2.Sub\n 3.Mod\n 4.Mul\n 5.Div\n 6.Exit");

                Console.Write("Enter choice");
                choice = Convert.ToInt32(Console.ReadLine());
                int num1=0,num2=0;
                if (choice != 6) { 
                    Console.Write("Enter First Number :");
                 num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number :");
                 num2 = Convert.ToInt32(Console.ReadLine());
            }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition is : {0}",(num1+num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction is : {0}", (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Modulo is : {0}", (num1 % num2));
                        break;
                    case 4:
                        Console.WriteLine("Multiplication is : {0}", (num1 * num2));
                        break;
                    case 5:
                        Console.WriteLine("Division is : {0}", (num1 / num2));
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default: Console.WriteLine("Invalid choilce");
                        break;
                }
    

            }
            while (choice!=6);
        }
    }
}

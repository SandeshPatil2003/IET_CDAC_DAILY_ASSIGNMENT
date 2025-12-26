using System.ComponentModel;

namespace CSharpFeaturesLinq
{

    public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Delegate Versions
            //Console.WriteLine("Enter a number");
            //int no = Convert.ToInt32(Console.ReadLine());

            //MyDelegate del = new MyDelegate(Check);

            //var result = del(no);

            //Console.WriteLine($"The number {no} is greater than 30 is : {result}");

            //MyDelegate del2 = num => num > 30;

            //var result2 = del2(no);


            //Console.WriteLine($"The number {no} is greater than 30 is : {result2}");


            //MyDelegate del3 = delegate (int num) { return num > 30; };

            //var result3 = del3(no);

            //Console.WriteLine($"The number {no} is greater than 30 is : {result3}");

            //MyDelegate del4 = (int num) => { return num > 30; };

            //var result4 = del4(no);

            //Console.WriteLine($"The number {no} is greater than 30 is : {result4}");

            //Predicate<int> del5 = num => num > 30;

            //var result5 = del5(no);

            //Console.WriteLine($"The number {no} is greater than 30 is : {result5}");

            #endregion


            #region Extensions

            int[] arr = { 5, 3, 1, 1, 7 };

            var sumresult = arr.Sum();

            Console.WriteLine($"Sum of Array is : {sumresult}");


            var sumresult2 = arr.CustomSum();

            Console.WriteLine($"Custom Sum of Array is : {sumresult2}");

            #endregion


            #region Check Email

            Console.WriteLine("Enter Email for Validation");

            string mail = Console.ReadLine();

            if (mail.CheckEmail())

                Console.WriteLine($"{mail} is Valid");
            else
                Console.WriteLine($"{mail} is Invalid");




            #endregion



        }
        public static bool Check(int num)
        {
            return num > 30;
        }





    }

    public static class CustomM
    {
        public static T CustomSum<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;

            foreach (T item in arr)
            {
                sum += item;
            }



            return sum;
        }

        public static bool CheckEmail(this string email)
        {
            return email.Contains("@iet.com");
        }

    }


}

using System;
using System.Collections;

namespace CSharpFeaturesForLINQ
{
    public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int no = 12;
            Console.WriteLine("Demonstrating multiple C# features in one program.\n");

           
            var result = Check(no);
            Console.WriteLine($"Normal Function Check: No {no} > 10? {result}");

            
            MyDelegate del = new MyDelegate(Check);
            result = del(no);
            Console.WriteLine($"Delegate Check: No {no} > 10? {result}");

            
            MyDelegate anonDel = delegate (int n)
            {
                return n > 10;
            };
            Console.WriteLine($"Anonymous Method Check: No {no} > 10? {anonDel(no)}");

            
            MyDelegate lambdaDel = n => n > 10;
            Console.WriteLine($"Lambda Expression Check: No {no} > 10? {lambdaDel(no)}");

            
            Predicate<int> pred = x => x > 10;
            Console.WriteLine($"Predicate Check: No {no} > 10? {pred(no)}");

            
            int[] numbers = { 1, 5, 2, 3 };
            var sum1 = numbers.Sum();
            var sum2 = MySum(numbers);
            Console.WriteLine($"\nSum results: built-in Sum() = {sum1}, MySum() = {sum2}");

            string[] names = { "Hugh", "John", "Tom" };
            
            string email = "user@example.com";
            Console.WriteLine($"\nEmail Validation (extension): {email.CheckForValidEmailID()}");

            
            int[] nums = { 101, 102, 103 };
            List<int> listFromNums = nums.ConvertToList(999);
            Console.WriteLine("Converted to List: " + string.Join(", ", listFromNums));

            string[] days = { "Mon", "Tue", "Wed" };
            List<string> dayList = days.ConvertToList(888);
            Console.WriteLine("Converted to List: " + string.Join(", ", dayList));

            
            Console.WriteLine("\nIterators Demo: MyCustomCollection");
            MyCustomCollection customCollection = new MyCustomCollection();
            customCollection.AddElement(10);
            customCollection.AddElement(20);
            customCollection.AddElement(30);
            foreach (var item in customCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nIterator Demo: MyCollection days");
            MyCollection collection = new MyCollection();
            foreach (var day in collection)
            {
                Console.WriteLine(day);
            }
        }

        public static bool Check(int num)
        {
            return num > 10;
        }

        public static T MySum<T>(IEnumerable<T> arr)
        {
            dynamic sum = 0;
            foreach (var ele in arr)
            {
                sum += ele;
            }
            return sum;
        }
    }

    public class MyCustomCollection : IEnumerable
    {
        private ArrayList arr = new ArrayList();
        public ArrayList GetElements
        {
            get { return arr; }
        }
        public void AddElement(int element)
        {
            arr.Add(element);
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Count; i++)
            {
                yield return arr[i];
            }
        }
    }

    public class MyCollection : IEnumerable
    {
        private string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }
    }

    public static class MyClass
    {
        
        public static bool CheckForValidEmailID(this string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        
        public static List<T> ConvertToList<T>(this IEnumerable<T> source, int nonsenseParameter)
        {
            List<T> list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }
            Console.WriteLine($"Nonsense Parameter value = {nonsenseParameter}");
            return list;
        }
    }
}

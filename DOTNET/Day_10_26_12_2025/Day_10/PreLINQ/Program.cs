namespace PreLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Delegates & LINQ Comprehensive Demo ===\n");

            #region 1. Predicate Delegates
            Predicate<int> _Even = x => x % 2 == 0;
            Predicate<int> _Odd = x => x % 2 != 0;
            int testNumber = 12;
            Console.WriteLine($"Predicate Demo - Number {testNumber}: Even={_Even(testNumber)}, Odd={_Odd(testNumber)}");
            #endregion

          

            #region 2. Action Delegates
            Console.WriteLine("\nAction Delegates Demo:");
            Action action1 = () => Console.WriteLine("Hello Hugh Jackman!");
            Action action2 = () => Console.WriteLine("Hello Tom Ellis!");
            Action action3 = () => Console.WriteLine("Hello Tom Holland!");

            action1(); action2(); action3();
            #endregion

            #region 3. Func Delegates (No input, with return)
            Console.WriteLine("\nFunc Delegates (No input) Demo:");
            Func<int> funcInt = () => 42;
            Func<double> funcDouble = () => 23.33;
            Func<string> funcString = () => "Hugh Jackman";

            Console.WriteLine($"Int: {funcInt()}");
            Console.WriteLine($"Double: {funcDouble()}");
            Console.WriteLine($"String: {funcString()}");
            #endregion

            #region 4. Func Delegates (With input, with return)
            Console.WriteLine("\nFunc Delegates (With input) Demo:");
            Func<int, bool> isEvenFunc = x => x % 2 == 0;
            Console.WriteLine($"12 is even: {isEvenFunc(12)}");
            Console.WriteLine($"13 is even: {isEvenFunc(13)}");
            #endregion

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"\nOriginal array: [{string.Join(", ", numbers)}]");

            #region 5. Built-in LINQ Where & Select
            Console.WriteLine("\nBuilt-in LINQ Where/Select Demo:");
            var evens = numbers.Where(x => x % 2 == 0);
            Console.WriteLine("Even numbers: " + string.Join(", ", evens));

            var doubled = numbers.Select(x => x * 2);
            Console.WriteLine("Doubled numbers: " + string.Join(", ", doubled));
            #endregion

            #region 6. Custom Extension Methods (MyWhere, MySelect)
            Console.WriteLine("\nCustom Extension Methods Demo:");
            var customResult = numbers.MySelect().MyWhere(x => x % 2 == 0);
            Console.WriteLine("Custom MySelect().MyWhere(): " + string.Join(", ", customResult));
            #endregion

            #region 7. Employee Data - Real-world LINQ Examples
            List<Emp> emps = new List<Emp>()
            {
                new() { Id = 1, Name = "Ganesh", Address = "Pune" },
                new() { Id = 2, Name = "Mitesh", Address = "Mumbai" },
                new() { Id = 3, Name = "Suresh", Address = "Patna" },
                new() { Id = 4, Name = "Prathmesh", Address = "Pune" },
                new() { Id = 5, Name = "Naresh", Address = "Mumbai" },
                new() { Id = 6, Name = "Jignesh", Address = "Puri" },
                new() { Id = 7, Name = "Suyash", Address = "Nashik" },
                new() { Id = 8, Name = "Durgesh", Address = "Pune" },
                new() { Id = 9, Name = "Pritesh", Address = "Pune" }
            };

            Console.WriteLine("\n=== Employee LINQ Demos ===");
            Console.WriteLine("Pune employees (Method Syntax):");
            var puneEmpsMethod = emps.Where(emp => emp.Address.ToLower() == "pune");
            foreach (var emp in puneEmpsMethod)
                Console.WriteLine($"  {emp.Id}: {emp.Name} - {emp.Address}");

            Console.WriteLine("\nPune employees (Query Syntax):");
            var puneEmpsQuery = from emp in emps
                                where emp.Address.ToLower().StartsWith("p")
                                select emp;
            foreach (var emp in puneEmpsQuery)
                Console.WriteLine($"  {emp.Id}: {emp.Name} - {emp.Address}");

            Console.WriteLine($"\nTotal employees: {emps.Count()}");
            Console.WriteLine($"Pune employees count: {emps.Count(emp => emp.Address == "Pune")}");
            #endregion
        }
    }

    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
    }

    public static class MyClass
    {
        public static List<T> MySelect<T>(this IEnumerable<T> source)
        {
            var list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }
            return list;
        }

        
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}


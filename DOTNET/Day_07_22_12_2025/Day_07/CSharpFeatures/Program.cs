namespace CSharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowPartialClasses();
            ShowNullableTypes();
            ShowObjectInitializers();
            ShowCollectionInitializers();
            ShowAutoProperties();
            ShowImplicitTypes();
            ShowAnonymousTypes();

            Console.WriteLine("\n--- Demo Complete ---");
            Console.ReadLine();
        }

        #region 1. Partial Classes
        static void ShowPartialClasses()
        {
            Console.WriteLine("--- 1. Partial Classes ---");
            // Partial classes allow a single class definition to be spread across multiple files.
            CMath cmath = new CMath();
            Console.WriteLine($"Add result: {cmath.Add(5, 10)}");
            Console.WriteLine($"Mult result: {cmath.Multiply(5, 10)}\n");
        }
        #endregion

        #region 2. Nullable Types
        static void ShowNullableTypes()
        {
            Console.WriteLine("--- 2. Nullable Types (?) ---");
            // Used when Value Types (int, DateTime, etc.) need to represent a 'null' state (e.g., from a Database).

            int? deptID = null;
            if (deptID.HasValue)
                Console.WriteLine($"DeptID: {deptID.Value}");
            else
                Console.WriteLine("DeptID is null");

            Nullable<int> altDept = 1234; // Alternative syntax
            if (altDept.HasValue)
                Console.WriteLine($"AltDept: {altDept.Value}\n");
        }
        #endregion

        #region 3. Object Initializers
        static void ShowObjectInitializers()
        {
            Console.WriteLine("--- 3. Object Initializers ---");
            // Allows assigning values to fields/properties at the time of creation without explicit constructors.
            Demo demo1 = new Demo { _id = 111, _name = "Hugh Jackman" };
            Console.WriteLine($"Initialized: {demo1._id} - {demo1._name}\n");
        }
        #endregion

        #region 4. Collection Initializers
        static void ShowCollectionInitializers()
        {
            Console.WriteLine("--- 4. Collection Initializers ---");
            // Syntax to initialize collections like Arrays or Lists succinctly.
            List<Demo> listDemoObjects = new List<Demo>()
            {
                new Demo { _id = 1, _name = "Hugh Jackman", _description = "Australian Actor" },
                new Demo { _id = 2, _name = "Tom Ellis", _description = "Welsh Actor" }
            };

            foreach (var dm in listDemoObjects)
            {
                Console.WriteLine($"ID: {dm._id}, Name: {dm._name}");
            }
            Console.WriteLine();
        }
        #endregion

        #region 5. Auto-Properties
        static void ShowAutoProperties()
        {
            Console.WriteLine("--- 5. Auto-Properties ---");
            // Simplifies property declaration when no extra logic is needed in getters/setters.
            Emp emp = new Emp()
            {
                EId = 101,
                EName = "Hugh Jackman",
                DOJ = DateTime.Now,
                Projects = new List<string> { "ORM", "API Integration" }
            };
            Console.WriteLine($"Employee: {emp.EName}, Joined: {emp.DOJ.ToShortDateString()}\n");
        }
        #endregion

        #region 6. Implicit Typing (var)
        static void ShowImplicitTypes()
        {
            Console.WriteLine("--- 6. Implicit Typing (var) ---");
            // 'var' lets the compiler determine the type at compile-time.
            var i = 100; // Compiled as int
            var str = "Hello"; // Compiled as string

            // Rules: Local scope only, must be initialized, cannot be used for parameters/fields.
            Console.WriteLine($"Types: i is {i.GetType()}, str is {str.GetType()}\n");
        }
        #endregion

        #region 7. Anonymous Types
        static void ShowAnonymousTypes()
        {
            Console.WriteLine("--- 7. Anonymous Types ---");
            // Encapsulate read-only properties into a single object without defining a class first.
            var v1 = new { Id = 101, Name = "John", Address = "Patna" };

            // Note: Properties are Read-Only. v1.Id = 102; would cause a compile error.
            Console.WriteLine($"Anonymous Type Name: {v1.GetType().Name}");
            Console.WriteLine($"Values: {v1.Id}, {v1.Name}\n");
        }
        #endregion
    }

    #region Supporting Classes
    
   
    public class Demo
    {
        public int _id;
        public string _name;
        public string _description;
    }

    public class Emp
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public bool isActive { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public List<string> Projects { get; set; }
    }

    public class Holder
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }

    public class Test
    {
        public object GetSomething(int? choice)
        {
            if (choice == 1) return 100;
            if (choice == 2) return new Emp { EId = 1, EName = "Timothy" };
            return null;
        }
    }

    #endregion
}


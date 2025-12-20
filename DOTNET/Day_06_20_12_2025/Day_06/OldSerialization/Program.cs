using System.Runtime.Serialization.Formatters.Binary;

namespace OldSerialization
{
    internal class Program
    {
        private static string filePath = @"C:\Users\IET\Desktop\000000074_75_DOTNET\Day_06_20_12_2025\Day_06\OldSerialization\Files\file1.txt";

        static void Main(string[] args)
        {
         
            Emp emp = new Emp()
            {
                Id = 101,
                Name = "SpiderMan",
                Address = "New York" 
            };

            
            SerializeEmployee(emp);

           
            DeserializeEmployee();

            Console.ReadLine();
        }


        static void SerializeEmployee(Emp emp)
        {
            FileStream fs = null;
            try
            {
               
                FileMode mode = File.Exists(filePath) ? FileMode.Append : FileMode.OpenOrCreate;
                fs = new FileStream(filePath, mode, FileAccess.Write);

                
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, emp);

                Console.WriteLine("Serialization Successful: Object saved to disk.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Serialization Error: {ex.Message}");
            }
            finally
            {
                fs?.Close(); 
            }
        }


        static void DeserializeEmployee()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File does not exist!");
                return;
            }

            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                
                Emp empData = bf.Deserialize(fs) as Emp;

                if (empData != null)
                {
                    Console.WriteLine("--- Deserialized Data ---");
                    Console.WriteLine($"Id      : {empData.Id}");
                    Console.WriteLine($"Name    : {empData.Name}");
                  
                    Console.WriteLine($"Address : {empData.Address}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deserialization Error: {ex.Message}");
            }
            finally
            {
                fs?.Close();
            }
        }
    }

    
    [Serializable]
    public class Emp
    {
        private int _Id;
        private string _Name;

         [NonSerialized]
        private string _Address;

        public int Id
        {
            get => _Id;
            set => _Id = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public string Address
        {
            get => _Address;
            set => _Address = value;
        }
    }
}


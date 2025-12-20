using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization
{
    internal class Program
    {

            static void Main(string[] args)
            {
                
                string xmlPath = @"C:\Users\IET\Desktop\000000074_75_DOTNET\Day_06_20_12_2025\Day_06\Serialization\Files\data.xml";
                string jsonPath = @"C:\Users\IET\Desktop\000000074_75_DOTNET\Day_06_20_12_2025\Day_06\Serialization\Files\data.json";

                
                Emp emp = new Emp
                {
                    Id = 101,
                    Name = "John Cena",
                    Address = "America"
                };

                #region XML Serialization
                Console.WriteLine("--- XML Serialization ---");
                using (FileStream fs = new FileStream(xmlPath, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Emp));
                    xmlSerializer.Serialize(fs, emp);
                    Console.WriteLine("XML Data Serialized.");
                }
                #endregion

                #region XML Deserialization
                if (File.Exists(xmlPath))
                {
                    using (FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Emp));
                        Emp xmlEmp = xmlSerializer.Deserialize(fs) as Emp;
                        Console.WriteLine($"XML Read: Id={xmlEmp?.Id}, Name={xmlEmp?.Name}, Address={xmlEmp?.Address}");
                    }
                }
                #endregion

                #region JSON Serialization
                Console.WriteLine("\n--- JSON Serialization ---");
                using (FileStream fs = new FileStream(jsonPath, FileMode.Create, FileAccess.Write))
                {
                    
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    JsonSerializer.Serialize(fs, emp, options);
                    Console.WriteLine("JSON Data Serialized.");
                }
                #endregion

                #region JSON Deserialization
                if (File.Exists(jsonPath))
                {
                    using (FileStream fs = new FileStream(jsonPath, FileMode.Open, FileAccess.Read))
                    {
                        Emp jsonEmp = JsonSerializer.Deserialize<Emp>(fs);
                        Console.WriteLine($"JSON Read: Id={jsonEmp?.Id}, Name={jsonEmp?.Name}, Address={jsonEmp?.Address}");
                    }
                }
                #endregion
            }
        }

        public class Emp
        {
            
            public int Id { get; set; }
            public string Name { get; set; }

           
            [XmlIgnore]
            [JsonIgnore]
            public string Address { get; set; }
        }
    }



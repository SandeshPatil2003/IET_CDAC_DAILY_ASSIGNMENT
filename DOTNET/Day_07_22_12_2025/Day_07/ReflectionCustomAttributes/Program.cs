using System.Reflection;

using IETAttribute;

namespace ReflectionCustomAttributes
{
    internal class Program
    {
        

            static void Main(string[] args)
            {
                string asmPath = @"C:\Users\IET\Desktop\000000074_75_DOTNET\Day_07_22_12_2025\Day_07\EmpLib\bin\Debug\net8.0\EmpLib.dll";

                Assembly asm = Assembly.LoadFrom(asmPath);
                Type[] allTypes = asm.GetTypes();
                for (int i = 0; i < allTypes.Length; i++)
                {
                    Type type = allTypes[i];
                    
                    Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                    for (int j = 0; j < allAttributes.Length; j++)
                    {
                        Attribute attr = allAttributes[j];
                        if (attr is IETSystemAttribute)
                        {
                        IETSystemAttribute ietAttr = attr as IETSystemAttribute;

                            Console.WriteLine($"Class {type.Name} is developed by {ietAttr.DeveloperName} of (c) {ietAttr.CompanyName}");
                        }

                        if (attr is SerializableAttribute)
                        {
                            Console.WriteLine($"Class {type.Name} is marked as Serializable");
                        }
                    }
                }

            }
        }
    }


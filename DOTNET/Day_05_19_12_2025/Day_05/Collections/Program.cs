using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //String Array

            string[] names = { "John Cena", "The Rock " };

            Console.WriteLine($"Array Access {names[0]} , {names[1]}");


            //Object Array

            Book book = new Book();

            book.Title = "Harry Potter";

            object[] mixedTypeData = { 100, "Hi", book }; 

            foreach(object obj in mixedTypeData)
            {
                if (obj is int i)
                {
                    Console.WriteLine($"Unboxed Int {i}");
                }
                else if (obj is string s)
                {
                    Console.WriteLine($"String : {s}");
                }
                else if( obj is Book b)
                {
                    Console.WriteLine($"Book is : {b.Title}");
                }

            }


            //Array List


            ArrayList alist = new ArrayList(){ 22,"john"};

            alist.Add(10.5);
            alist.Add("World!");

            Console.WriteLine($"ArrayList Count is {alist.Count}");


            //HashTable

            Hashtable htable = new Hashtable();
            htable.Add("id", 10001);
            htable["name"] = "johncena";

            Console.WriteLine($"HashTable value by key : {htable["id"]} , {htable["name"]}");
            //List generic
            List<string> marvelList = new List<string> { "IronMan", "Captain America", "Hulk" };

            marvelList.Add("Hawkeye");

            Console.WriteLine($"List access generic: {marvelList[0]} , {marvelList[1]}");


            //Tuples

            var avenger = GetAvenger();

            Console.WriteLine($"Avenger : {avenger.name}  State : {avenger.state}");

            







            
        }

        static (string name , string state) GetAvenger()
        {
            return ("IronMan", "California");
        }
    }
}

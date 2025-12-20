namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Write File (StreamWriter)

            /* string filePath = @"C:\Users\IET\Desktop\000000074_75_DOTNET\Day_06_20_12_2025\Day_06\FileHandling\Files\file1.txt";


             FileStream fs = null;

             if (File.Exists(filePath))
             {

                 fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);

             }
             else
             {

                 fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

             }

             StreamWriter wr = new  StreamWriter(fs);

             wr.WriteLine("First Line");

             wr.Flush();
             wr.Close();
             fs.Close();


             Console.WriteLine("File added");*/

            #endregion


            #region Read File (StreamReader)

            //string filePath = @"C:\Users\IET\Desktop\000000074_75_DOTNET\Day_06_20_12_2025\Day_06\FileHandling\Files\file1.txt";

            //FileStream fs = null;

            //if (File.Exists(filePath))
            //{

            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);




            //StreamReader rd = new StreamReader(fs);

            //string output = rd.ReadToEnd();

            //rd.Close();

            //Console.WriteLine($"output is : {output}");
            //}
            //else
            //{
            //    Console.WriteLine("File does not exist");
            //}
            //fs.Close();


            #endregion


            #region Append File (StreamWriter)

            //string filePath = @"C:\Users\IET\Desktop\000000074_75_DOTNET\Day_06_20_12_2025\Day_06\FileHandling\Files\file1.txt";


            //FileStream fs = null;

            //if(File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append,FileAccess.Write);

            //}
            //else
            //{
            //    fs = new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.Write);


            //}

            //StreamWriter wr = new StreamWriter(fs);

            //wr.WriteLine("This is added line");

            //wr.Flush();
            //wr.Close();
            //fs.Close();

            //Console.WriteLine("Append done");





            #endregion


            #region Writing Object Data To File (StreamWriter)


            //Employee emp = new Employee(2, "The Rock", "Wrestler");

            //string filePath = @"C:\Users\IET\Desktop\000000074_75_DOTNET\Day_06_20_12_2025\Day_06\FileHandling\Files\emp1.txt";


            //FileStream fs = null;

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);

            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //}


            //StreamWriter wr = new StreamWriter(fs);

            //wr.WriteLine(emp.ToString());
            //wr.Flush();
            //wr.Close();
            //fs.Close();

            //Console.WriteLine("Done");
            #endregion
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DBTest.DAL
{
    internal class DBContext


    {
        static String connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SandeshDB;Integrated Security=True;";
        List<Emp> elist = new List<Emp>();
        public void add()
        {

            SqlConnection conn = new SqlConnection(connectionstring);

            string query = $"SELECT * FROM Emp";
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                elist.Add(new Emp(reader[0] as int?, reader[1].ToString()));

            }

            foreach (Emp emp in elist)
            {
                Console.WriteLine($"Id = {emp.EId}, EName = {emp.EName}");
            }

        }
       
    }
    public class Emp
    {
        public int? EId { get; set; }

        public string? EName { get; set; }

        public Emp(int? eId, string? eName)
        {
            EId = eId;
            EName = eName;
        }

    }
}

using AdoDotNetConnectedArchitecture.Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetConnectedArchitecture.DAL
{
    internal class DBContext
    {
        List<User> uList = new List<User>();   
        public DBContext() { }

       static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SandeshDB;Integrated Security=True;";

       // string ur = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;";

        SqlConnection conn = new SqlConnection(connectionString);

        //public int registerUser(User user)
        //{
        //    SqlCommand cmd = new SqlCommand(
        //       $"INSERT INTO [User](Name,Email,Password,Role) Values('{user.UName}','{user.UEmail}','{user.UPassword}','{user.URole}')"
        //        ,conn);

        //    conn.Open();

        //    int n = cmd.ExecuteNonQuery();

        //    return n;
        //}
        public int registerUser(User user)
        {
            // 1. Fully qualify the table name to avoid 'Invalid Object' or Keyword conflicts
            string query = "INSERT INTO [dbo].[User] (Name, Email, Password, Role) VALUES (@Name, @Email, @Pass, @Role)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // 2. Use Parameters to handle string escaping automatically
                    // This prevents syntax errors from single quotes in user input (e.g., O'Brian)
                    cmd.Parameters.AddWithValue("@Name", user.UName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", user.UEmail ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pass", user.UPassword ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Role", user.URole ?? "user");

                    if (conn.State != System.Data.ConnectionState.Open)
                        conn.Open();

                    int n = cmd.ExecuteNonQuery();
                    return n;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                return 0;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        internal bool validate(string? uname, string? password)
        {
            string query = "SELECT * FROM [dbo].[User]";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType=System.Data.CommandType.Text;
            cmd.Connection = conn;
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                if (reader["Name"].ToString().Equals(uname)
                    &&
                    reader["Password"].ToString().Equals(password)
                    )
                {
                    return true;
                }
            }


                return false;
                
         }
    }

}

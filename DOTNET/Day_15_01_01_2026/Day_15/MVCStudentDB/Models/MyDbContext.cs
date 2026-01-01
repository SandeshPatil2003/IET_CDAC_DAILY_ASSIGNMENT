using Microsoft.Data.SqlClient;

namespace MVCStudentDB.Models
{
    public class MyDbContext
    {

        private readonly string? _connectionString;
        public MyDbContext(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("lol");


        }


        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("select * from student", con))
                {


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            students.Add(new Student()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                AdmissionDate = DateOnly.FromDateTime(Convert.ToDateTime(reader["AdmissionDate"])),
                                Percentage = Convert.ToDouble(reader["Percentage"])


                            });

                        }


                    }


                }



                


            }

            return students;



        }
    }
}

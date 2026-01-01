namespace MVCStudentDB.Models
{
    

        public class Student
        {

            public int Id { get; set; }

            public string Name { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public DateOnly AdmissionDate { get; set; }

            public double Percentage { get; set; }


        }
    
}

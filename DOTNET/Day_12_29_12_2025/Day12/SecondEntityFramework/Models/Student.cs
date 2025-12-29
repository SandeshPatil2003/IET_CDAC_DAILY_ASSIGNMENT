using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondEntityFramework.Models
{

    [Table("StudentData")]
    public class Student
    {


        
        private int _studentId;

        [Key]
        [Column("StudentID", TypeName = "int")]
        public int StudentID
		{
			get { return _studentId; }
			set { _studentId = value; }
		}


        
        private string? _studentName;

        [Column("StudentName", TypeName = "varchar(50)")]
        public string? StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }


        
        private double _studentMarks;

        [Column("StudentMarks", TypeName = "float")]
        public double StudentMarks
        {
            get { return _studentMarks; }
            set { _studentMarks = value; }
        }

        
        private DateTime _studentAdmissionDate;


        [Column("StudentAdmissionDate", TypeName = "date")]
        public DateTime StudentAdmissionDate
        {
            get { return _studentAdmissionDate; }
            set { _studentAdmissionDate = value; }
        }



    }
}

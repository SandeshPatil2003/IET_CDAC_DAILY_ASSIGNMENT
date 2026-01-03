using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VSB.Models
{

    [Table("UserTable")]
    public class User
    {
        public User()
        {
        }

        [Key]
        [Column("userid",TypeName ="int")]
        public int UId { get; set; }

        [Column("username", TypeName = "varchar(50)")]
        public string? UserName { get; set; }


        [Column("email", TypeName = "varchar(50)")]
        public string? UserEmail { get; set; }


        [Column("password", TypeName = "varchar(50)")]
        public string? UserPass { get; set; }

        [Column("role", TypeName = "varchar(50)")]
        public string? UserRole { get; set; }

        public User(int uId, string? userName, string? userEmail, string? userPass, string? userRole)
        {
            UId = uId;
            UserName = userName;
            UserEmail = userEmail;
            UserPass = userPass;
            UserRole = userRole;
        }
        //For User account creation
        public User(string? userName, string? userEmail, string? userPass, string? userRole)
        { 
            UserName = userName;
            UserEmail = userEmail;
            UserPass = userPass;
            UserRole = "User";
        }


        //For mechanic account creation
        //public User(string? userName, string? userEmail, string? userPass, string? userRole)
        //{
        //    UserName = userName;
        //    UserEmail = userEmail;
        //    UserPass = userPass;
        //    UserRole = userRole;
        //}


        public override string? ToString()
        {
            return $"UserName = {UserName}, UserEmail = {UserEmail}, UserROle = {UserRole}";
        }
    }
}


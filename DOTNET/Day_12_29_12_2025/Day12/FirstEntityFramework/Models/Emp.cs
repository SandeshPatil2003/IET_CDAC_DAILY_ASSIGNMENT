
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FirstEntityFramework.Models
{
    [Table("Emp")] // Explicitly names the table "Emp" in the DB
    public class Emp
    {
        [Key] // Primary Key + Identity (1,1) auto-increment
        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar(50)")]
        public string? Name { get; set; }

        [Column("Address", TypeName = "varchar(50)")]
        public string? Address { get; set; }
    }
}

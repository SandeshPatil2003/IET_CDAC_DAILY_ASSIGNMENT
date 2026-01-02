using Microsoft.EntityFrameworkCore;

namespace MVCEntityFramework.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Emp> emps { get; set; }
       public MyDbContext( DbContextOptions options ):base(options)
        {

        }
    }
}

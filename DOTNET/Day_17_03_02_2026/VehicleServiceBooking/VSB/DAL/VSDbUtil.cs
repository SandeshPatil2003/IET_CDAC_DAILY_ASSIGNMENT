using Microsoft.EntityFrameworkCore;
using VSB.Models;

namespace VSB.DAL
{
    public class VSDbUtil : DbContext
    {

         public DbSet<User> users {  get; set; }
        public DbSet<VehicleService> vehicleservices { get; set; }
        public VSDbUtil(DbContextOptions<VSDbUtil> options) : base(options) { }
    }
}

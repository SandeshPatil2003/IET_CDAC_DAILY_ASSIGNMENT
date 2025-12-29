using Microsoft.EntityFrameworkCore;

using FirstEntityFramework.Models;
using Microsoft.Extensions.Configuration;

namespace FirstEntityFramework.DAL
{
    public class IETDbContext :DbContext
    {

        public DbSet<Emp> emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 1. Setup Configuration to read appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Set path to current executable folder
                .AddJsonFile("appsettings.json");              // Load the json file

            IConfiguration config = builder.Build();

            // 2. Extract Connection String and tell EF to use SQL Server
            // Ensure "IETDb" matches the key in your appsettings.json
            string? connectionString = config.GetConnectionString("IETDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
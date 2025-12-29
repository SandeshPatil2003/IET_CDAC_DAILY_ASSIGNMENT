using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SecondEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondEntityFramework.DAL
{
    public class TestDbContext :DbContext
    {

        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("TestDatabase1"));


        }



    }
}

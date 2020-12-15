using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLaboratory2.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=corelabDB2; integrated security=true;");
        }
        public DbSet<Laboratory> Laboratorys{get; set;}
        public DbSet<Employee> Employees{get; set;}
        public DbSet<Test> Tests{get; set;}
    }
}

using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDemo.DB
{
    //Used to communicate with the DB
    public class AppDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        public string connectionString { get; }

        public AppDbContext()
        {
            this.connectionString = "Host=localhost;Port=5544;Database=appdb;Username=appuser;Password=apppassword";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(this.connectionString);
        }
    }
}

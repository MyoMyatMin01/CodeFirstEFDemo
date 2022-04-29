using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstEFDemo
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id)
                .ToTable("Employees");

            modelBuilder.Entity<EmployeeContact>()
                .HasKey(e => e.Id)
                .ToTable("Employees");

            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.EmployeeContact)
                .WithRequiredPrincipal(e => e.Employee);

            base.OnModelCreating(modelBuilder);
        }
    }
}
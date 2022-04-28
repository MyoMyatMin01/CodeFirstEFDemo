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
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures();
            modelBuilder.Entity<Employee>()
                .Map(emp =>
                {
                    emp.Properties(p => new
                    {
                        p.Id,
                        p.FirstName,
                        p.LastName
                    });
                    emp.ToTable("EmployeeName");
                })
                .Map(emp =>
                {
                    emp.Properties(p => new
                    {
                        p.Id,
                        p.Gender,
                        p.Salary
                    });
                    emp.ToTable("EmployeeSalary");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
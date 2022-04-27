using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstEFDemo
{
    public class EmployeeDBSeeder : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            Department department = new Department()
            {
                Name = "IT", Location = "Yangon",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Min", LastName = "Myo", Gender = "Male", Salary = 50000
                    },
                    new Employee()
                    {
                        FirstName = "Aung", LastName = "Thu", Gender = "Male", Salary = 65000
                    },
                    new Employee()
                    {
                        FirstName = "Myat", LastName = "Min", Gender = "Male", Salary = 80000
                    },
                    new Employee()
                    {
                        FirstName = "Htoon", LastName = "Min", Gender = "Male", Salary = 70000
                    }
                }
            };
            context.Departments.Add(department);
            base.Seed(context);
        }
    }
}
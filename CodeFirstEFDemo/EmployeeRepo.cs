using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEFDemo
{
    public class EmployeeRepo
    {
        EmployeeDBContext context = new EmployeeDBContext();

        public List<Employee> GetEmployee()
        {
            EmployeeDBContext context = new EmployeeDBContext();
            return context.Employees.Include("EmployeeContact").ToList();
        }
    }
}
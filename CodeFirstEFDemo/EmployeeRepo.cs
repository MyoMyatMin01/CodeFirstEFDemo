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
            return context.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee empToUpdate = context.Employees.Find(employee.Id);
            empToUpdate.FirstName = employee.FirstName;
            empToUpdate.LastName = employee.LastName;
            empToUpdate.Gender = employee.Gender;
            empToUpdate.Salary = employee.Salary;
            context.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            Employee empToDelete = context.Employees.Find(employee.Id);
            context.Employees.Remove(empToDelete);
            context.SaveChanges();
        }
    }
}
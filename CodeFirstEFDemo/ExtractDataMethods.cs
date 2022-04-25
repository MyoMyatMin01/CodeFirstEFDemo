using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEFDemo
{
    public class ExtractDataMethods
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBContext context = new EmployeeDBContext();
            return context.Department.ToList();
        }
    }
}
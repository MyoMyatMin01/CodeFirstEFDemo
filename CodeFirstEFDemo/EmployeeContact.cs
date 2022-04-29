using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEFDemo
{
    public class EmployeeContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Employee Employee { get; set; }
    }
}
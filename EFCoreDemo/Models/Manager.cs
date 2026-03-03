using System;
using System.Collections.Generic;
using System.Text;

namespace EFDemo.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }

        public string Name { get; set; }

        // One to Many relationship: A Manager can have multiple Employees
        public ICollection<Employee> Employees { get; set; } // Navigation property to Employees

    }
}

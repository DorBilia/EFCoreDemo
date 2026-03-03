using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDemo.Models
{
    public class Employee
    {
        [Key] // Explicitly specify Primary key
        public int EmployeeId { get; set; }
        
        public string Name { get; set; }

        public int EmployeeSalary { get; set; }

        public EmployeeDetails EmployeeDetails { get; set; } // Navigation property to dependent entity EmployeDetails

        public int ManagerId { get; set; } // Foreign key to Manager

        public Manager Manager { get; set; } // Navigation property to Manager
    }
}

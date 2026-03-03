using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Models
{
    // Junction table for many-to-many relationship between Employee and Project
    public class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } // Navigation property to Employee

        public int ProjectId { get; set; }
        public Project Project { get; set; } // Navigation property to Project
    }
}

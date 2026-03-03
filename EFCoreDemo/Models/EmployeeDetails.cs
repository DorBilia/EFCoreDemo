using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDemo.Models
{
    public class EmployeeDetails
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public int EmployeeId { get; set; } // Foreign key to Employee

        public Employee Employee { get; set; } // Navigation property to Employee
    }
}

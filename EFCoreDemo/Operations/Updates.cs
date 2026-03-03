using EFCoreDemo.DB;
using EFCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace EFCoreDemo.Operations
{
    public static class Updates
    {
        private static AppDbContext DbContext = DbContextSingletone.GetDbContext();

        public static void UpdateEmployee(int OldEmployeeId, Employee NewEmployee)
        {

            var OldEmployee = Retrievs.GetEmployeeById(OldEmployeeId);
          
            if (OldEmployee != null)
            {
                OldEmployee.Name = NewEmployee.Name;
                OldEmployee.EmployeeSalary = NewEmployee.EmployeeSalary;
                OldEmployee.EmployeeDetails = NewEmployee.EmployeeDetails;
                OldEmployee.ManagerId = NewEmployee.ManagerId;
                DbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Employee with id {OldEmployeeId} not found.");
            }
        }
    }
}

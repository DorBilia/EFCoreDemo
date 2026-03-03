using System;
using System.Linq;
using EFCoreDemo.DB;
using EFCoreDemo.Models;

namespace EFCoreDemo.Operations
{
    public static class Retrievs
    {
        private static AppDbContext DbContext = DbContextSingletone.GetDbContext();

        public static void ShowEmployees()
        {

            var employees = DbContext.Employees.ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }

        public static Employee GetEmployeeById(int employeeId)
        {
            var employee = DbContext.Employees.Single(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                return employee;
            }
            else
            {
                Console.WriteLine($"Employee with ID {employeeId} not found.");
                return null;
            }
        }
    }
}
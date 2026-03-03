using EFCoreDemo.Models;
using EFCoreDemo.Operations;

Retrievs.ShowEmployees();
Employee e1 = new Employee { Name = "Mark P", EmployeeSalary = 70000, ManagerId = 1};
Updates.UpdateEmployee(2, e1);
Retrievs.ShowEmployees();

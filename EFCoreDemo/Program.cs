using EFDemo.Models;
using EFDemo.DB;

static void AddManager(AppDbContext dbContext,Manager manager)
{
    dbContext.Managers.Add(manager);
    dbContext.SaveChanges();
}

static void AddEmployee(AppDbContext dbContext, Employee employee)
{
    dbContext.Employees.Add(employee);
    dbContext.SaveChanges();
}

var dbContext = new AppDbContext();


//var manager = new Manager();
//manager.Name = "John Doe";
//AddManager(dbContext, manager);

var employee = new Employee();
employee.Name = "Jane Smith";
employee.EmployeeSalary = 50000;
employee.ManagerId = 1; // Assuming the manager with ID 1 exists
AddEmployee(dbContext, employee);
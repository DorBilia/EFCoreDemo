using EFCoreDemo.DB;
using EFCoreDemo.Models;

namespace EFCoreDemo.Operations
{
    public static class Inserts
    {
        // Static shared AppDbContext attribute
        private static AppDbContext DbContext = DbContextSingletone.GetDbContext();

        public static void AddManager(Manager manager)
        {
            DbContext.Managers.Add(manager);
            DbContext.SaveChanges();
        }

        public static void AddEmployee(Employee employee)
        {
            DbContext.Employees.Add(employee);
            DbContext.SaveChanges();
        }

        public static void AddProject(Project project)
        {
            DbContext.Projects.Add(project);
            DbContext.SaveChanges();
        }

        public static void AddEmployeeToProject(int employeeId, int projectId)
        {
            var projectEmployee = new EmployeeProject
            {
                EmployeeId = employeeId,
                ProjectId = projectId
            };
            DbContext.EmployeeProjects.Add(projectEmployee);
            DbContext.SaveChanges();
        }

        public static void AddEmployeeDetails(EmployeeDetails employeeDetails)
        {
            DbContext.EmployeeDetails.Add(employeeDetails);
            DbContext.SaveChanges();
        }

        // Optional: replicate original sample usage as a single seed method.
        public static void Sample()
        {
            // Add a manager
            var manager = new Manager { Name = "John Doe" };
            AddManager(manager);

            // Add an employee linked to the created manager
            var employee = new Employee
            {
                Name = "Jane Smith",
                EmployeeSalary = 50000,
                ManagerId = manager.ManagerId // use the generated ID after AddManager
            };
            AddEmployee(employee);

            // Add employee details for the employee
            var employeeDetails = new EmployeeDetails
            {
                EmployeeId = employee.EmployeeId,
                Address = "123 Main St",
                PhoneNumber = 123456,
                Email = "JaneSmith@mail.com"
            };
            AddEmployeeDetails(employeeDetails);

            // Create a project and link the employee to it
            var project = new Project { Name = "Project Alpha" };
            AddProject(project);

            // Add entry in the project-employee join table
            AddEmployeeToProject(employee.EmployeeId, project.ProjectId);
        }
    }
}


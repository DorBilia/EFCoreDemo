using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }

    }
}

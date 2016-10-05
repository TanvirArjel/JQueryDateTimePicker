using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JQueryDatePicker.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("JQueryDatePicker")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
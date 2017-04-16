using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JQueryDatePicker.Models
{
    public class DatePickerDbContext : DbContext
    {
        public DatePickerDbContext() : base("JQueryDatePicker")
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
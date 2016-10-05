using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JQueryDatePicker.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [Required]
        [Display(Name = "Joining Date")]
        public DateTime? JoiningDate { get; set; }
    }
}
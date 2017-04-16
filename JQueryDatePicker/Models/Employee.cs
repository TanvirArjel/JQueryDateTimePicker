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

        [Display(Name = "Joining Date")]
        [DisplayFormat(DataFormatString = "{0: dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }
    }
}
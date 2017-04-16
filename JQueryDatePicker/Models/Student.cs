using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JQueryDatePicker.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd-MMM-yyyy HH:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDateTime { get; set; }

    }
}
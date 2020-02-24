using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Registration
    {
        
        public int registrationID { get; set; }
        [Display(Name = "Student ID")]
        
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
        [Display(Name = "Course ID")]
        
        public int courseID { get; set; }
        public virtual Course Course { get; set; }

    }
}
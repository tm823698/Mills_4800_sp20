using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Course
    {
        public int courseID { get; set; }
        [Display (Name= "Class Time")]
        [DataType(DataType.Time)]
        
        public string classTime { get; set; }
        [Display(Name = "Instructor")]
        [Required(ErrorMessage = "Instructor name required.")]
        [StringLength(20)]
        public string instructor { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please enter a description for the class.")]
        [StringLength(50)]
        public string description { get; set; }
        public ICollection<Registration> Registration { get; set; }
    }
}
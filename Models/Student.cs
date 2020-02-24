using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Student
    {
        public int studentID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Student first name is required.")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Student last name is required.")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please use your most used email address.")]
        [DataType (DataType.EmailAddress)]
        [StringLength(50)]

        public string email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        public ICollection<Registration> Registration { get; set; }
    }
}
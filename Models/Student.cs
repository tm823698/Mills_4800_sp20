using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public ICollection<Registration> Registration { get; set; }
    }
}
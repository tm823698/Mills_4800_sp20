using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string classTime { get; set; }
        public string instructor { get; set; }
        public string description { get; set; }
        public ICollection<Registration> Registration { get; set; }
    }
}
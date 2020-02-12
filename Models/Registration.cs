using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Registration
    {
        
        public int registrationID { get; set; }
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
        public int courseID { get; set; }
        public virtual Course Course { get; set; }

    }
}
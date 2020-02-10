using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        public string description { get; set; }
        public DateTime appointmentDate { get; set; }
        public decimal appointmentCost { get; set; }
        
        public ICollection<Doctor> Doctor { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
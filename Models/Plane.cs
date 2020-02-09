using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Plane
    {
        [Key]
        public int planeID { get; set; }

        public string planeName { get; set; }
        public string startingLocation { get; set; }
        public ICollection<FlightDetail> FlightDetail { get; set; }
    }
    
   
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class FlightDetail
    {
        public int flightDetailID { get; set; }

        public decimal price { get; set; }
        public int numberOfTickets { get; set; }
        public int planeID { get; set; }
        public DateTime orderDate { get; set; }

        public virtual Plane Plane { get; set; }

        // the next two properties link the orderDetail to the Product

        public int productID { get; set; }

        public virtual Passenger Passenger { get; set; }
    }
}
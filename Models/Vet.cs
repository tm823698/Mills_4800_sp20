using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mills_4800.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }
        public ICollection<Pet> Pet { get; set; }
    }
    public class Pet
    {
        public int petID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<Vet> Vet { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int customerID { get; set; }
        public virtual Vetpet Vetpet { get; set; }
    }
    public class Vetpet
    {
        public int owenerID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Pet> Pet { get; set; }
    }
}
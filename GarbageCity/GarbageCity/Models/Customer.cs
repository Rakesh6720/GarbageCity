using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarbageCity.Models
{
    

    public class Customer
    {
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string PickupDay { get; set; }

    }
}

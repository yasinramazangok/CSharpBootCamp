using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Customer
    {
        /*
        [Key]
        public int CustomerID { get; set; }
        */

        public int CustomerId { get; set; } // [ClassName]Id = Default Primary Key Definition for EntityFramework

        public string Name { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public List<Order> Orders { get; set; }

        public bool Status { get; set; }
    }
}

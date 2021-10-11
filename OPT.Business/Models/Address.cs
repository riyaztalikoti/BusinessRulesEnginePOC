using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPT.Business.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string ZIP { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Landmark { get; set; }

        public string Phone { get; set; }
    }
}

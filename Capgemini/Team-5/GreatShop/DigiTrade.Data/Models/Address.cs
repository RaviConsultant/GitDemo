using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Data.Models
{
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customers>();
        }

        public int AddressId { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Data.Models
{
    public partial class Customers
    {
        public Customers()
        {
            SalesInvoices = new HashSet<SalesInvoices>();
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string HouseNum { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<SalesInvoices> SalesInvoices { get; set; }
    }
}

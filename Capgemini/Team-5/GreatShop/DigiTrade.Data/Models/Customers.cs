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
            SaleInvoices = new HashSet<SaleInvoices>();
        }

        public int CustId { get; set; }
        public string CustName { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<SaleInvoices> SaleInvoices { get; set; }
    }
}

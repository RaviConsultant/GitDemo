using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Demo.Models
{
    public partial class Customer
    {
        public Customer()
        {
            SalesInvoices = new HashSet<SalesInvoices>();
        }

        public int Id { get; set; }
        public string CustName { get; set; }
        public string CustPhone { get; set; }
        public string CustEmail { get; set; }
        public string CustAddress { get; set; }

        public virtual ICollection<SalesInvoices> SalesInvoices { get; set; }
    }
}

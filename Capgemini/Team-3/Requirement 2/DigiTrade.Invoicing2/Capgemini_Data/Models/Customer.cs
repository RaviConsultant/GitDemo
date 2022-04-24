using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Capgemini_Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            SalesInvoices = new HashSet<SalesInvoice>();
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
    }
}

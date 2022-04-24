using System;
using System.Collections.Generic;

#nullable disable

namespace DigiTradeData.Models
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

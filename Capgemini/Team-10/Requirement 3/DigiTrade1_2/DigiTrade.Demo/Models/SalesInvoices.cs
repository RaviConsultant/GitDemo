using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Demo.Models
{
    public partial class SalesInvoices
    {
        public int InvoiceNum { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public long Rate { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Product Product { get; set; }
    }
}

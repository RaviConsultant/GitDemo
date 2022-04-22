using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Data.Models
{
    public partial class SalesInvoices
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? CustomerId { get; set; }
        public int Qty { get; set; }
        public int? ProductId { get; set; }
        public int Rate { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Products Product { get; set; }
    }
}

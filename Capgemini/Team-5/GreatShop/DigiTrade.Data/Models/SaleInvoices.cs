using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Data.Models
{
    public partial class SaleInvoices
    {
        public int InvoiceNo { get; set; }
        public DateTime? Invoicedate { get; set; }
        public int? CustId { get; set; }
        public int? ProdId { get; set; }
        public int Qty { get; set; }
        public int Rate { get; set; }

        public virtual Customers Cust { get; set; }
        public virtual Products Prod { get; set; }
    }
}

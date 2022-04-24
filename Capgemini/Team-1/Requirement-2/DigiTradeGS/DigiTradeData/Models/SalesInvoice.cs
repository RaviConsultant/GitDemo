using System;
using System.Collections.Generic;

#nullable disable

namespace DigiTradeData.Models
{
    public partial class SalesInvoice
    {
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public int Rate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}

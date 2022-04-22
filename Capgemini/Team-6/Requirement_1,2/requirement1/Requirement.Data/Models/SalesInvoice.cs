using System;
using System.Collections.Generic;

#nullable disable

namespace Requirement.Data.Models
{
    public partial class SalesInvoice
    {
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
    }
}

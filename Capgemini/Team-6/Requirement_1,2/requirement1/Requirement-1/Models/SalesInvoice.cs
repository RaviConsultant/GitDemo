using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requirement_1.Models
{
    public class SalesInvoice
    {
        [Key]
        public int InvoiceNumber { get; set; }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? InvoiceDate { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }

        [ForeignKey("ProductID")]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Rate { get; set; }
        

    }
}

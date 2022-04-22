using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTrade.Invoicing.Models
{
    public class SaleInvoice
    {

        [Key]
        public int InvoiceNumber { get; set; }    // Primary Key - Auto-incremented
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? InvoiceDate { get; set; }



        [DisplayFormat(NullDisplayText = "Customer")]
        [Display(Name = "Customer")]
        // public string CustomerName { get; set; }



        public int? CustomerId { get; set; }
        [Display(Name = "Customer Name")]
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [DisplayFormat(NullDisplayText = "No Product")]
        [Display(Name = "Product")]

        public int? ProductId { get; set; }
        [Display(Name = "Product ")]
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        [Range(typeof(int), "0", "100")]

        public int Qty { get; set; }
        public double Rate { get; set; }
    }
}


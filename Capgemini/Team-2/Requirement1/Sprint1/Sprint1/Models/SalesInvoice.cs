using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1.Models
{
    public class SalesInvoice
    {
        // Primary Key - Auto-incremented
        public int Id { get; set; }

        [Required]
        [Display(Name = "Invoice Date")]
        [DataType(DataType.Date),
        DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
         ApplyFormatInEditMode = true)]
        public DateTime? InvoiceDate { get; set; }

        [DisplayFormat(NullDisplayText ="No Customer")]
        [Display(Name ="Customer Id")]
        public int? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer CustomerID{ get; set; }

        [DisplayFormat(NullDisplayText ="No Product")]
        [Display(Name = "Product")]
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public  Product Product{ get; set; }

        
        [Required(ErrorMessage = "Quantity Name is required !")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }


        [Required]
        [Display(Name ="Rate")]
        public int Rate { get; set; }

        
        
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTradeASP.NETWEBAPP.Models
{
    public class SalesInvoice
    {
        //primary key
        [Key]
        public int InvoiceNo { get; set; }

        [Display(Name = "Invoice Date")]
        [DataType(DataType.Date),
        DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Invoicedate { get; set; }

        //foreign key
        [DisplayFormat(NullDisplayText = "No Customer")]
        [Display(Name = "Customer")]
        public int? Cust_Id { get; set; }

        [Display(Name = "Customer")]
        [ForeignKey("Cust_Id")]
        public Customer CustName { get; set; }


        //foreign key
        [DisplayFormat(NullDisplayText = "No Product")]
        [Display(Name = "Product")]
        public int? Prod_Id { get; set; }


        [Display(Name = "Product")]
        [ForeignKey("Prod_Id")]
        public Product ProdName { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Qty { get; set; }

        [Required]
        [Display(Name = "Rate")]
        public int Rate { get; set; }


    }
}

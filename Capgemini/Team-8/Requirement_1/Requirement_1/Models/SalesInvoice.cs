using System;
using System.ComponentModel.DataAnnotations;

namespace Requirement_1.Models
{
    public class SalesInvoice
    {
        [Key]
        public int Invoice_Num { get; set; }

        [DataType(DataType.Date),
        DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Invoice_Date { get; set; }

        public int Customer_Id { get; set; }

        public int Product { get; set; }

        public int Qty { get; set; }

        public int Rate { get; set; }
    }
}

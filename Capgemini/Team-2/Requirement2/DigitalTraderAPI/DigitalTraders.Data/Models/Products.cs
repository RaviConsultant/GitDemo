using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigitalTraders.Data.Models
{
    public partial class Products
    {
        public Products()
        {
            SalesInvoice = new HashSet<SalesInvoice>();
        }

        public int Id { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public decimal SalePrice { get; set; }
        public int CurrentStock { get; set; }
        public int? BrandId { get; set; }
        public string Processor { get; set; }
        public int Ram { get; set; }
        public int Rom { get; set; }
        public int PrimaryCamera { get; set; }
        public int FrontCamera { get; set; }
        public int Battery { get; set; }

        

       
        public virtual Brands Brand { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoice { get; set; }
    }
}

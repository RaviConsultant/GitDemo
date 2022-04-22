using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.DataLayer.Models
{
    public partial class Products
    {
        public Products()
        {
         //   SaleInvoices = new HashSet<SaleInvoices>();
        }

        public int ProductId { get; set; }
        public string Title { get; set; }
        public double SalePrice { get; set; }
        public int CurrentStock { get; set; }
        public int Tax { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Rom { get; set; }
        public string PrimaryCamera { get; set; }
        public string FrontCamera { get; set; }
        public string Battery { get; set; }
        public int? BrandId { get; set; }

        public virtual Brands Brand { get; set; }
       // public virtual ICollection<SaleInvoices> SaleInvoices { get; set; }
    }
}

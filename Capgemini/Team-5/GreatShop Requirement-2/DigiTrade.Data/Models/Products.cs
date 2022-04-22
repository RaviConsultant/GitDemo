using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Data.Models
{
    public partial class Products
    {
        //public Products()
        //{
        //    SaleInvoices = new HashSet<SaleInvoices>();
        //}

        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Rom { get; set; }
        public string Battery { get; set; }
        public string PrimaryCam { get; set; }
        public string FrontCam { get; set; }
        public int CurrentStock { get; set; }
        public int SalesPrice { get; set; }
        public int Tax { get; set; }
        public int? BrandId { get; set; }

        public virtual Brands Brand { get; set; }
        //    public virtual ICollection<SaleInvoices> SaleInvoices { get; set; }
    }
}

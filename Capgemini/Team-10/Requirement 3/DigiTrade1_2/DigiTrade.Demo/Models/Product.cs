using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Demo.Models
{
    public partial class Product
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long SalePrice { get; set; }
        public long CurStock { get; set; }
        public byte? Tax { get; set; }
        public int? BrandId { get; set; }
        public string Processor { get; set; }
        public short Ram { get; set; }
        public short Rom { get; set; }
        public byte PrimaryCam { get; set; }
        public byte FrontCam { get; set; }
        public short Battery { get; set; }

        public virtual Brand Brand { get; set; }
       // public virtual ICollection<SalesInvoices> SalesInvoices { get; set; }
    }
}

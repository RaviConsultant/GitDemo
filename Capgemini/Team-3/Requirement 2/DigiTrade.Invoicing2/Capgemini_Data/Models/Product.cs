using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Capgemini_Data.Models
{
    public partial class Product
    {
        public Product()
        {
            SalesInvoices = new HashSet<SalesInvoice>();
        }

        public int Id { get; set; }
        public string ProductTitle { get; set; }
        public string Discription { get; set; }
        public long SalePrice { get; set; }
        public long CurStock { get; set; }
        public long Tax { get; set; }
        public int BrandId { get; set; }
        public string Processor { get; set; }
        public long Ram { get; set; }
        public long Rom { get; set; }
        public long PrimaryCam { get; set; }
        public long FrontCam { get; set; }
        public long Battery { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
    }
}

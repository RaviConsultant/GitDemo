using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class Product
    {
        public Product()
        {
            SalesDetail = new HashSet<SalesDetail>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double? SalePrice { get; set; }
        public int? CurStock { get; set; }

        public virtual ICollection<SalesDetail> SalesDetail { get; set; }
    }
}

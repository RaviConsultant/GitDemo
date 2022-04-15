using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class SalesDetail
    {
        public int Id { get; set; }
        public string InvNo { get; set; }
        public int? ProdId { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }

        public virtual Product Prod { get; set; }
    }
}

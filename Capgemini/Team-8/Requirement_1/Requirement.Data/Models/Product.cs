using System;
using System.Collections.Generic;

#nullable disable

namespace Requirement.Data.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductTitle { get; set; }
        public string Description { get; set; }
        public int SalePrice { get; set; }
    }
}

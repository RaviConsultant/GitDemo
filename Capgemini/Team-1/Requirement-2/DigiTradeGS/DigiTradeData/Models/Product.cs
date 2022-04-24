using System;
using System.Collections.Generic;

#nullable disable

namespace DigiTradeData.Models
{
    public partial class Product
    {
        
        public int Id { get; set; }
        public string ProductTitle { get; set; }
        public string Description { get; set; }
        public long SalePrice { get; set; }
        public long Cur_Stock { get; set; }
        public long Tax { get; set; }
        public int BrandId { get; set; }
        public string Processor { get; set; }
        public long Ram { get; set; }
        public long Rom { get; set; }
        public long PrimaryCamera { get; set; }
        public long FrontCamera { get; set; }
        public long Battery { get; set; }

        public virtual Brand Brand { get; set; }
        
    }
}

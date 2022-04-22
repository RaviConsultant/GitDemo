using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigiTradeAPI.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public double SalePrice { get; set; }
        public int CurrentStock { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Rom { get; set; }
        public string PrimaryCamera { get; set; }
        public string FrontCamera { get; set; }
        public string Battery { get; set; }
        public int? BrandId { get; set; }


    }
}
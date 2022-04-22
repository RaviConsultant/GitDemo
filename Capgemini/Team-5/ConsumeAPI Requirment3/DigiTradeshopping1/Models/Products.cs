using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigiTradeshopping1.Models
{
    public class Products
    {
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
    }
}
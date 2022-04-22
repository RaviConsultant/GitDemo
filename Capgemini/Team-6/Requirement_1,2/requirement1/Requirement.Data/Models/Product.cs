using System;
using System.Collections.Generic;

#nullable disable

namespace Requirement.Data.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public double SalePrice { get; set; }
        public float Tax { get; set; }
        public long Rom { get; set; }
        public long Ram { get; set; }
        public long PrimaryCam { get; set; }
        public long MainCam { get; set; }
        public int Battery { get; set; }
        public string Processor { get; set; }
        public int CurStock { get; set; }
    }
}

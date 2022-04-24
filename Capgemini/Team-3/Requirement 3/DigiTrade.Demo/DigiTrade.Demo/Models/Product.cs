using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DigiTrade.Demo.Models
{
    public class Product
    {
        //public int Id { get; set; }

        //public string ProductTitle { get; set; }

        //public string ProductDescription { get; set; }

        //public decimal SalePrice { get; set; }

        //public int CurrentStock { get; set; }

        //public string Brand { get; set; }

        //public string Processor { get; set; }

        //public int RAM { get; set; }

        //public int ROM { get; set; }

        //public int PrimaryCamera { get; set; }

        //public int FrontCamera { get; set; }

        //public int Battery { get; set; }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        // public long PurPrice { get; set; }
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

       // public virtual Brand Brand { get; set; }
    }
}

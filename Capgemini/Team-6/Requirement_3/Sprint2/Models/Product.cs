using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sprint2.Models
{
    public class Product
    {
        public int Id { get; set; }
     

        public string Title { get; set; }


        public string brandName { get; set; }



        public string Description { get; set; }

        public double SalePrice { get; set; }

        
        public float Tax { get; set; }

    
        public uint ROM { get; set; }

        public uint RAM { get; set; }

     

        public uint PrimaryCam { get; set; }

      

        public uint MainCam { get; set; }

        

        public int Battery { get; set; }


        public string Processor { get; set; }


        public int curStock { get; set; }

    }
}
namespace DigitalTradersAPIcall.Models
{
  
        public class Product
        {
            public int Id { get; set; }

            public string ProductTitle { get; set; }

            public string ProductDescription { get; set; }

            public decimal SalePrice { get; set; }

            public int CurrentStock { get; set; }

            public string Brand { get; set; }

            public string Processor { get; set; }

            public int RAM { get; set; }

            public int ROM { get; set; }

            public int PrimaryCamera { get; set; }

            public int FrontCamera { get; set; }

            public int Battery { get; set; }


        public decimal Price
        {
            get
            {
                return SalePrice * 90 / 100;
            }
        }
    }
    }


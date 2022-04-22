using DigiTradeMVC.NET.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTradeASP.NETWEBAPP.Models
{
    public class Product
    {
        //primary key
        [Key]
        public int Prod_Id { get; set; }

        [Required]
        [StringLength(64, MinimumLength = 4)]
        [Display(Name = "Product Name")]
        public string ProdName { get; set; }

        [Required]
        [Display(Name = "Processor")]
        public string Processor { get; set; }

        [Required]
        [Display(Name = "RAM")]
        public string Ram { get; set; }

        [Required]
        [Display(Name = "ROM")]
        public string Rom { get; set; }

        [Required]
        [Display(Name = "Battery")]
        public string Battery { get; set; }

        [Required]
        [Display(Name = "Primary Camera")]
        public string Primary_cam { get; set; }

        [Required]
        [Display(Name = "Front Camera")]
        public string Front_cam { get; set; }

        [Required]
        [Display(Name = "Current Stock ")]
        public int Current_Stock { get; set; }

        [Required]
        [Display(Name = "Sales Price")]
        public int Sales_Price { get; set; }

        [Required]
        [Display(Name = "TAX")]
        public int Tax { get; set; }

        //foreign key
        [DisplayFormat(NullDisplayText = "No Brand")]
        [Display(Name = "Brand")]
        public int? Brand_Id { get; set; }

        [Display(Name = "Brand")]
        [ForeignKey("Brand_Id")]
        public Brand BrandName { get; set; }



    }
}

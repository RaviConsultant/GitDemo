using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1.Models
{
    public class Product
    {
   
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Title is required !")]
        [StringLength(32, ErrorMessage = "Maximum of 32 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        [Display(Name = "Product Title")]
        public string ProductTitle { get; set; }

        [Required(ErrorMessage = "Product Description is required !")]
        [StringLength(128, ErrorMessage = "Maximum of 128 Characters only !")]
        [MinLength(8, ErrorMessage = "Minimum of 8 Characters required !")]
        [Display(Name = " Product Description")]
        public string ProductDescription { get; set; }


        [Required(ErrorMessage = "Sale Price is required !")]
        [Display(Name = " Sale Price")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal SalePrice { get; set; }

        [Required(ErrorMessage = "Current Stock is required !")]
        [Display(Name = " Current Stock")]
        public int CurrentStock { get; set; }

        [DisplayFormat(NullDisplayText = "No Brand")]
        [Display(Name = "Brand")]
        public int? BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }

        [Required(ErrorMessage = "Processor is required !")]
        [StringLength(16, ErrorMessage = "Maximum of 16 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        [Display(Name = "Processor")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "Product RAM is required !")]
        [Display(Name = " RAM")]
        public int Ram { get; set; }

        [Required(ErrorMessage = "Product ROM is required !")]
        [Display(Name = " ROM")]
        public int ROM { get; set; }

        [Required(ErrorMessage = "Primary Camera is required !")]
        [Display(Name = " Primary Camera")]
        public int PrimaryCamera { get; set; }

        [Required(ErrorMessage = "Front Camera is required !")]
        [Display(Name = "Front Camera")]
        public int FrontCamera { get; set; }

        [Required(ErrorMessage = "Product Battery is required !")]
        [Display(Name = "Battery")]
        public int Battery { get; set; }
        
        
        

    }
}

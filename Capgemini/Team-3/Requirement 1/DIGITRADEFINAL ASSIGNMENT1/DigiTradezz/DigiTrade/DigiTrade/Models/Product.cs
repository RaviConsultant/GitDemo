using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTrade.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }    // Primary Key - Auto-incremented

        [Required(ErrorMessage = "Product Title is required!")]
        [StringLength(15, ErrorMessage = "Maximum of 15 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        public string ProductTitle { get; set; }

        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(5, ErrorMessage = "Minimum of 5 characters required")]
        public string Discription { get; set; }
        
        [Required(ErrorMessage = "Only Positive Value")]
        //[Required(ErrorMessage = "Sale Price is required!")]
        [Display(Name = "SalePrice(Rs)")]
        public uint SalePrice { get; set; }
       
        [Required(ErrorMessage = "Current Stock is required!")]
        [Display(Name = "Current Stock")]
        public uint CurStock { get; set; }

        [Required]
        public uint Tax { get; set; }

        [Required]
        [Display(Name = "Brand")]
        public virtual int BrandID { get; set; }
        [ForeignKey("BrandID")]
        public virtual Brand Brand { get; set; }
        

        [Required]
        [StringLength(15, ErrorMessage = "Maximum of 15 Characters only !")]
        public string Processor { get; set; }

        [Required]
        [Range(8, 16, ErrorMessage = "RAM Should be between 8 and 16.... Try Again !")]
        public uint RAM { get; set; }

        [Required]
        [Range(16, 128, ErrorMessage = "ROM Should be between 16 and 128 !")]
        public uint ROM { get; set; }
        [Required]
        [Range(32, 108, ErrorMessage = "Maximum of 108 GB only and Minimum 32 GB only !")]
        public uint PrimaryCam { get; set; }
        [Required]
        [Range(16, 64, ErrorMessage = "Maximum of 64 MP and Minimum 16 MP only !")]
        public uint FrontCam { get; set; }
        [Required]
        [Range(1000, 5000, ErrorMessage = "Maximum of 5000 mAH only and Minimum 1000 mAH only !")]
        public uint Battery { get; set; }


    }

}


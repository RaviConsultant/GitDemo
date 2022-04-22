using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTrade.Invoicing.Models
{
    public class Product
    {

        // Primary Key - Auto-incremented
        [Key]
        public int ProductId { get; set; }

        [Required]

        [StringLength(32)]
        [MinLength(2, ErrorMessage = "Product Name should be 2 to 32 Characters")]
        public string Title { get; set; }

        //[Required]
        //[StringLength(200)]
        //[MinLength(2, ErrorMessage = "Description can not be null")]
        //public string Description { get; set; }

        [Required]
        
       // [Range(typeof(int), "0","100000")]

        public double Sale_Price { get; set; }
        [Required]
        [Range(typeof(int), "0", "500")]
        public int Current_Stock { get; set; }

        [Required]
        [Range(typeof(int), "0", "50")]

        public int Tax { get; set; }
       
        [Required]
        [StringLength(40)]
        [MinLength(2, ErrorMessage = "Processor Details can not be null")]

        public string Processor { get; set; }
        [Required]

        [StringLength(60)]
        [MinLength(1, ErrorMessage = "RAM size can not be null")]
        public string RAM { get; set; }
        [Required]
        [StringLength(60)]
        [MinLength(1, ErrorMessage = "ROM size can not be null")]

        public string ROM { get; set; }

        [Required]
        [StringLength(60)]
        [MinLength(1, ErrorMessage = "Primary Camera size can not be null")]

        public string Primary_Camera { get; set; }

        [Required]
        [StringLength(60)]
        [MinLength(1, ErrorMessage = "Front Camera size can not be null")]

        public string Front_Camera { get; set; }

        [Required]
        [StringLength(60)]
        [MinLength(1, ErrorMessage = "Battery capacity can not be null")]

        public string Battery { get; set; }


        //[DisplayFormat(NullDisplayText = "No Brands")]
        //[Display(Name = "Brand")]
        //// public string BrandName { get; set; }

        ////public string BrandName { get; set; }
        //public int? BrandId { get; set; }
        //[Display(Name = "Brand")]
        //[ForeignKey("BrandId")]

        //BrandModel BrandName { get; set; }

        //foreign key
        [DisplayFormat(NullDisplayText = "No Brands")]
        [Display(Name = "Brand")]
        public int? BrandId { get; set; }

        [Display(Name = "Brand")]
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }




        //[DisplayFormat(NullDisplayText = "No Brand")]
        //[Display(Name = "Brand")]
        //public int? DescriptionId { get; set; }

        //[Display(Name = "Description")]
        //[ForeignKey("DescriptionId")]
        //public Description Description { get; set; }

    }
}


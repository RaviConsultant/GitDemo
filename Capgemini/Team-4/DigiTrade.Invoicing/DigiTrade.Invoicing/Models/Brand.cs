using System.ComponentModel.DataAnnotations;

namespace DigiTrade.Invoicing.Models
{
    public class Brand
    {

        [Key]
        public int BrandId { get; set; }



        // Primary Key - Auto-incremented


        [Required(ErrorMessage = "Brand Name is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        [Display(Name = "Brand")]
        public string BrandName { get; set; }

        //[DisplayFormat(NullDisplayText = "No Description")]
        //[Display(Name = "Description")]

        //public string Processor { get; set; }
        ////public int? DescriptionId { get; set; }

        //[ForeignKey("DescriptionId")]

        //Description Description { get; set; }

    }
}

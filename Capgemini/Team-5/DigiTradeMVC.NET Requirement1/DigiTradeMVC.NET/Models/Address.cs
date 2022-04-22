using System.ComponentModel.DataAnnotations;

namespace DigiTradeMVC.NET.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Display(Name = "Building Name")]
        public string Building { get; set; }

        [Required]
        [Display(Name = "Street Name")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Area")]
        public string Area { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public string Zip { get; set; }
    }
}

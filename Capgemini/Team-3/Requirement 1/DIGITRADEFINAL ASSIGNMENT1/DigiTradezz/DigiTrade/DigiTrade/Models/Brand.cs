using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTrade.Models
{
    public class Brand
    {
        [Key]
        public int ID { get; set; }    // Primary Key - Auto-incremented

        [Required(ErrorMessage = "Brand Name is required !")]
        [StringLength(20, ErrorMessage = "Maximum of 16 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        public string BrandName { get; set; }
    }
}

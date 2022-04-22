using System.ComponentModel.DataAnnotations;

namespace Requirement_1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product title is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]

        public string Product_title { get; set; }

        [Required(ErrorMessage = "description is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]

        public string Description { get; set; }

        public int Sale_Price { get; set; }
    }
}

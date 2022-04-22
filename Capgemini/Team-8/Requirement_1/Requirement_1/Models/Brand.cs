using System.ComponentModel.DataAnnotations;

namespace Requirement_1.Models
{
    public class Brand
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Brand name is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]

        public string Product_title { get; set; }
    }
}

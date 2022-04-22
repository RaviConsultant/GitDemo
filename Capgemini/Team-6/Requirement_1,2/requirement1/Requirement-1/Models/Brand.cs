using System.ComponentModel.DataAnnotations;

namespace Requirement_1.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Brand Name is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [Display(Name = " Brand_Name")]
        public string Brand_Name { get; set; }
        
    

    }
}

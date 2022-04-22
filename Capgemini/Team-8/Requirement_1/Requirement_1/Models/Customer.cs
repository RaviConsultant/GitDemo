using System.ComponentModel.DataAnnotations;

namespace Requirement_1.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]

        public string Customer_Name { get; set; }
        [Required]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "10 digits numbers only Example: 9512341234")]
        [StringLength(10)]
        [MinLength(10, ErrorMessage = "Mobile Phone should be in 10 digits 1234567890 format")]
        public string Customer_phone { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(128)]
        [MinLength(2, ErrorMessage = "Email Phone should be in raj@mail.com format")]
        public string Customer_Email { get; set; }

        public string Address { get; set; }
    }
}

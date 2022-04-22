using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requirement_1.Models
{
    public class Customer
    {
        [Key]
        // Primary Key - Auto-incremented
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer Name is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        [Display(Name = " Customer_Name")]
        public string Customer_Name { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(128, ErrorMessage = "Email Phone should be in raj@mail.com format")]
        public string Customer_Email { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "10 digits numbers only- Example: 9512341234")]
        [StringLength(10)]
        //[MinLength(10, ErrorMessage = "Mobile Phone should be in 10 digits1234567890 format")]
        public string Customer_Phone{ get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "Address should not exceed 128 characters ")]
        public string Address { get; set; }
    }

}

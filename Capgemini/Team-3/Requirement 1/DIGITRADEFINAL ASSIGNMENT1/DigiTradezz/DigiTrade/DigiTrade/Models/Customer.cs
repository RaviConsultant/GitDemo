using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTrade.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }    // Primary Key - Auto-incremented

        [Required(ErrorMessage = "Customer Name is required!")]
        [StringLength(20, ErrorMessage = "Maximum of 20 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }


        [Required(ErrorMessage = "Phone Number is required!")]
        [StringLength(12, ErrorMessage = "Maximum of 12 Characters only !")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress]
        [StringLength(128, ErrorMessage = "Email Phone should be in raj123@gmail.com format")]
        [Display(Name = "Customer Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        public string Address { get; set; }

    }
}

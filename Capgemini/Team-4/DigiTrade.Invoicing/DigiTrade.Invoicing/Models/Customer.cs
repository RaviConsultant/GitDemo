using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTrade.Invoicing.Models
{
    public class Customer
    {

        [Key]
        // Primary Key - Auto-incremented
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        //[MinLength(2, ErrorMessage = "Customer Name should be 2 to 32 Characters")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "10 digits numbers only - Example: 9512341234")]
        [StringLength(10)]
        //[MinLength(10, ErrorMessage = "Mobile Phone should be in 10 digits 1234567890 format")]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(128)]
        //[MinLength(128, ErrorMessage = "Email Phone should be in raj @mail.com format")]
        public string Email { get; set; }


        //[Required]

        //[StringLength(128)]
        //[MinLength(128, ErrorMessage = "Address can not be null")]
        //public string Address { get; set; }


        [DisplayFormat(NullDisplayText = "No Address")]
        [Display(Name = "Address")]

        // public string City { get; set; }
        public int? AddressId { get; set; }
        [Display(Name = "Address")]
        [ForeignKey("AddressId")]

        public Address Address { get; set; }

    }
}

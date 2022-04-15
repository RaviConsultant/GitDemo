using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assingment_solution_1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(32)]
        [MinLength(2, ErrorMessage = "First Name should be 2 to 32 Characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(32)]
        [MinLength(2, ErrorMessage = "Last Name should be 2 to 32 Characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date),
        DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
        ApplyFormatInEditMode = true)]
        public DateTime? DOB { get; set; }
        [Required]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "10 digits numbers only- Example: 9512341234")]
        [StringLength(10)]
        //[MinLength(10, ErrorMessage = "Mobile Phone should be in 10 digits 1234567890 format")]
        public string Mobile { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(128)]
        //[MinLength(128, ErrorMessage = "Email Phone should be inraj @mail.com format")]
        public string Email { get; set; }
        [DisplayFormat(NullDisplayText = "No Category")]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }
        [Display(Name = "Category")]
        [ForeignKey("CategoryId")]
        public CustCategory CustCategory { get; set; }
    }
}

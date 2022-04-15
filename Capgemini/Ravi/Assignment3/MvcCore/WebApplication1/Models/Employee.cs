using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    //[Table("Emp")]  // incase you need to have a different name for your database table
    public class Employee
    {
        // Primary Key - Auto-incremented
        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        [MinLength(6, ErrorMessage = "Employee Code should be 6 Characters.  Ex:  M10054")]
        public string Code { get; set; }

        [Required]
        [StringLength(32)]
        [MinLength(2, ErrorMessage = "First Name should be 2 to 32 Characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(32)]
        [MinLength(2, ErrorMessage = "Last Name should be 2 to 32 Characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // complex type
        //public Address Address { get; set; }


        [Display(Name = "Date of Joining")]
        [DataType(DataType.Date),
         DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
         ApplyFormatInEditMode = true)]
        public DateTime? DOJ { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "10 digits numbers only - Example: 9512341234")]
        [StringLength(10)]
        //[MinLength(10, ErrorMessage = "Mobile Phone should be in 10 digits 1234567890 format")]
        public string Mobile { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(128)]
        //[MinLength(128, ErrorMessage = "Email Phone should be in raj@mail.com format")]
        public string Email { get; set; }

        [DisplayFormat(NullDisplayText = "No Department")]
        [Display(Name = "Department")]
        public int? DepartmentId { get; set; }

        [Display(Name = "Department")]
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

    }
}

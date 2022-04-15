using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Customers.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(32)]
        [MinLength(3, ErrorMessage = "First Name should be 3 to 32 Characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        [Required]
        [Phone]
        [MinLength(10, ErrorMessage = "Mobile Number should be 10 digits or 12 with country code")]
        [StringLength(12)]
        public int Mobile { get; set; }
        public string Email { get; set; }
        public int? Category { get; set; }

        public virtual CustCategory CategoryNavigation { get; set; }
    }
}

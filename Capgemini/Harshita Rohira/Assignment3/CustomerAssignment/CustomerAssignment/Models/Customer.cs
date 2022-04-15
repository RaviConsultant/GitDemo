using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerAssignment.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(32)]
        [MinLength(3, ErrorMessage = "First Name should be 3 to 32 Characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

       // public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public int? Category { get; set; }

        public virtual CustCategory CategoryNavigation { get; set; }
    }
}

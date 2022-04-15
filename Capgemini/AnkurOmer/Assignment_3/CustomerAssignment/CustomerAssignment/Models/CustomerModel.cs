using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerAssignment.Models
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }
       
        [StringLength(32, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Dob { get; set; }

        public string Email { get; set; }


        [StringLength(12)]
        [Required]
        public string Mobile { get; set; }

        public string Category { get; set; }
    }
}

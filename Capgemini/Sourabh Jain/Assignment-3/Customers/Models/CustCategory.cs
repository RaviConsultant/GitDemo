using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Customers.Models
{
    public partial class CustCategory
    {
        public CustCategory()
        {
            Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        [MinLength(3, ErrorMessage = "Category Name should be 3 to 32 Characters")]
        [Display(Name = "CatName")]
        public string CatName { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}

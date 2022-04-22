using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Sprint1.Models
{
    public class Customer
    {
        //Primary Key - Auto-incremented
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required !")]
        [StringLength(32, ErrorMessage = "Maximum of 32 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

       
        [Required(ErrorMessage = "Phone Number is required !")]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "10 digits number only")]
        [StringLength(10)]
        [MinLength(10, ErrorMessage = "Minimum of 10 Numbers required !")]
        [Display(Name = "Customer Phone")]
        public string  CustomerPhone { get; set; }


        
        [Required(ErrorMessage = "Email is required !")]
        [EmailAddress]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [Display(Name = " Customer Email")]
        public string CustomerEmail { get; set; }


        [Required(ErrorMessage = "House number is required !")]
        [Display(Name = " House Number")]
        public string HouseNum { get; set; }
       
        [Required(ErrorMessage = "Street is required !")]
        [Display(Name = " Street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Area is required !")]
        [Display(Name = " Area")]
        public string Area { get; set; }

        [Required(ErrorMessage = "City is required !")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Zip is required !")]
        [Display(Name = "Zip")]
        public string Zip { get; set; }

        
        public string Address
        {
            get
            {
                return HouseNum + " " + Street + " " + Area+ " "+ City+ " " + Zip;
            }
        }
    }
}

using DigiTradeMVC.NET.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiTradeASP.NETWEBAPP.Models
{
    public class Customer
    {
        //primary key
        [Key]
        public int Cust_Id { get; set; }

        [Required]
        [StringLength(64)]
        [Display(Name = "Customer Name")]
        public string CustName { get; set; }


        [Required]
        [Display(Name = "Mobile Number")]
        [StringLength(10)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Email")]
        public string EmailId { get; set; }

        [DisplayFormat(NullDisplayText = "No Address")]
        [Display(Name = "Address")]
        public int? AddressId { get; set; }

        [Display(Name = "Address")]
        [ForeignKey("AddressId")]
        public Address City { get; set; }
        


    }
}

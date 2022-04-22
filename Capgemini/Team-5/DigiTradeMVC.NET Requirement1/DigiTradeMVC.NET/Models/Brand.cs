using System.ComponentModel.DataAnnotations;

namespace DigiTradeASP.NETWEBAPP.Models
{
    public class Brand
    {
        //primary key
        [Key]
        public int Brand_Id { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 2)]
        [Display(Name = "Brand")]
        public string BrandName { get; set; }
    }
}

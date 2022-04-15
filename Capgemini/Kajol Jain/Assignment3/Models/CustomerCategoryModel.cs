using System.ComponentModel.DataAnnotations;

namespace CustomerAssignment.Models
{
    public class CustomerCategoryModel
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string CatName { get; set; }    
    }
}

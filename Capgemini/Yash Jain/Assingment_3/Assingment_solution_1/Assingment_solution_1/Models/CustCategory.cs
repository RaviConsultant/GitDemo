using System.ComponentModel.DataAnnotations;

namespace Assingment_solution_1.Models
{
    public class CustCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department Name is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        [Display(Name = " Department")]
        public string Name { get; set; }
    }

}


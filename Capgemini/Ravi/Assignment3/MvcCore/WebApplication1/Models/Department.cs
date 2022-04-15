using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Department
    {
        // Primary Key - Auto-incremented
        public int Id { get; set; }
        //public int DepartmentsId { get; set; }

        //[Key]  // if the name is not Id or DepartmentId
        //public int DeptId { get; set; }

        [Required(ErrorMessage = "Department Name is required !")]
        [StringLength(64, ErrorMessage = "Maximum of 64 Characters only !")]
        [MinLength(2, ErrorMessage = "Minimum of 2 Characters required !")]
        [Display(Name = " Department")]
        public string Name { get; set; }
    }

}

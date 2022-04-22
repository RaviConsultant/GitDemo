using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Requirement_1.Models
{
    public class Product
    {
        // Primary Key - Auto-incremented
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        [MinLength(2, ErrorMessage = "Name should be 2 to 32 Characters")]

        public string Title { get; set; }

        [Required]
        [StringLength(32)]
        [MinLength(2, ErrorMessage = "Brand Name should be 2 to 32 Characters")]
        public string Brand_Name { get; set; }


        [Required]
        [StringLength(512)]
        [MinLength(2, ErrorMessage = "Minimum description should be 2 to 512 Characters")]
        public string Description { get; set; }

        [Required]
        [Range(8999,99999, ErrorMessage ="Enter a value between 8999 and 99999")]
        public double SalePrice { get; set; }

        [Required]
        [Range(0.01,100.0, ErrorMessage ="Enter a value between 0.01 and 100.0")]
        public float Tax { get; set; }

        [Required]
        [Range(32, 512, ErrorMessage ="Enter a range between 32 and 512")]
        public uint ROM { get; set; }

        [Required]
        [Range(4, 16, ErrorMessage = "Enter a range between 4 and 16")]
        public uint RAM { get; set; }

        [Required]
        [Range(16,108, ErrorMessage ="Enter a range between 16 and 108")]

        public uint PrimaryCam { get; set; }

        [Required]
        [Range(16, 108, ErrorMessage = "Enter a range between 16 and 108")]

        public uint MainCam {get; set; }

        [Required]
        [Range(3000, 6000, ErrorMessage ="Enter a number between 3000 and 6000")]

        public int Battery { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Processor name should be minimum 6 Characters.")]
        [StringLength(32)]

        public string Processor { get; set; }

        [Required]
        [Range(1,9999, ErrorMessage ="Enter a number between 1 and 9999")]

        public int Cur_stock { get; set; }




    }
}

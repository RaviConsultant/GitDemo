using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Pay = new HashSet<Pay>();
        }

        public short Id { get; set; }
        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public byte? DeptId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Department Dept { get; set; }
        public virtual ICollection<Pay> Pay { get; set; }
    }
}

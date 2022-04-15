using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class Pay
    {
        public int Id { get; set; }
        public short EmpId { get; set; }
        public double BasicPay { get; set; }
        public double? Conveyance { get; set; }
        public double? SpecialPay { get; set; }
        public byte PayMonth { get; set; }
        public short PayYear { get; set; }

        public virtual Employee Emp { get; set; }
    }
}

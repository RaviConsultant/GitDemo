using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class SalesHead
    {
        public int Id { get; set; }
        public string InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public int? CustId { get; set; }

        public virtual Customer Cust { get; set; }
    }
}

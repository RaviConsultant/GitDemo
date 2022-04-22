using System;
using System.Collections.Generic;

#nullable disable

namespace Requirement.Data.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string Address { get; set; }
    }
}

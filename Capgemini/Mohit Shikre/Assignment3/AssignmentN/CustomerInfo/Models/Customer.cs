﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CustomerInfo.Models
{
    public partial class Customer
    {
        public byte Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public byte? Category { get; set; }

        public virtual CustCategory CategoryNavigation { get; set; }
    }
}

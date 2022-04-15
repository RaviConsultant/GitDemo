using System;

namespace IBank.utility
{
    //creating address class
    public class Address
    {
        public string Street;
        public string Area;
        public string City;
        public string Zip;
    }

    // creating contactinfo class
    public class ContactInfo
    {
        public string Phone;
        public string Mobile;
        public string Email;
    }

    //creating customer class
    public class Customer
    {
        public string FirstName;
        public string LastName;
        Address CustAddress;
        ContactInfo CustContact;
    }

    // creating  Branch class
    public class Branch
    {
        public string BranchName;
        Address BranchAddress;
        ContactInfo BranchContact;
    }
}

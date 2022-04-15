using System;

namespace IBank.Utility
{
    public struct Customer
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public ContactInfo ContactInfo;
    }

    public struct Branch
    {
        public string Name;
        public string Address;
        public ContactInfo ContactInfo;
    }

    public struct Address
    {
        public string City;
        public string Street;
        public string Zip;
        public string Area;
    }
     
    public struct ContactInfo
    {
        public long Phone;
        public long Mobile;
        public string Email;
    }
}

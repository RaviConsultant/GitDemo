using System;

namespace Utility
{
    public struct Customer
    {
        public string FirstName;
        public string LastName;
        public Address address;
        public ContactInfo contactInfo;
    }

    public struct Branch
    {
        public string Name;
        public Address address;
        public ContactInfo contactInfo;
    }

    public struct Address
    {
        public string City;
        public string Street;
        public int Zip;
        public string Area;
    }

    public struct ContactInfo
    {
        public long Phone;
        public long Mobile;
        public string Email;
    }


}

using System;

namespace IBank.Utility
{
     // creating multiple struct in library class
    // to remove code redundancy
    public struct Address
    {
        string street;
        string area;
        string city;
        string zip;
    }
    public struct ContactInfo
    {
        string phone;
        string mobile;
        string Email;
    }
    public struct Branch
    {
        string b_name;
        Address b_address;
        ContactInfo b_contactInfo;

    }
    public struct Customer
    {
        string First_Name;
        string Last_Name;
        Address address;
        ContactInfo contactinfo;
    }
}

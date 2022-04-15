using System;

namespace IBank.Utility1
{
    
    public struct Address// creating structure of Address
    {
        string street;
        string area;
        string city;
        string zip;
    }
    public struct ContactInfo // creating structure of ContactInfo
    {
        string phone;
        string mobile;
        string Email;
    }
    public struct Branch// creating structure of Branch
    {
        string b_name;
        Address b_address;
        ContactInfo b_contactInfo;

    }
    public struct Customer // creating structure of Customer
    {
        string First_Name;
        string Last_Name;
        Address address;
        ContactInfo contactinfo;
    }
}

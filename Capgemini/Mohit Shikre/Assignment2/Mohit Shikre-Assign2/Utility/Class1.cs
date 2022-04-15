using System;

namespace IBank.Utility1
{/// <summary>
/// /creating multiple struct in library class
/// to remove code redundancy
/// </summary>
    public struct Address// creating structure of Address with different attributes
    {
        string street;
        string area;
        string city;
        string zip;
    }
    public struct ContactInfo // creating structure of ContactInfo with different attributes
    {
        string phone;
        string mobile;
        string Email;
    }
    public struct Branch// creating structure of Branch with different attributes
    {
        string b_name;
        Address b_address;
        ContactInfo b_contactInfo;

    }
    public struct Customer // creating structure of Customer with different attributes
    {
        string First_Name;
        string Last_Name;
        Address address;
        ContactInfo contactinfo;
    }
}

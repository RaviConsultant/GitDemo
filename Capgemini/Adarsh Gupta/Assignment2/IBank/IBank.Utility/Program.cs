using System;

namespace IBank.Utility
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Address
    {
        public string street;
        public string area;
        public string city;
        public string zip;
    }
    public class ContactInfo
    {
        public string phone;
        public string mobile;
        public string email;
    }
    public class Customer
    {
        public string firstName;
        public string lastName;
        public Address custAdd;
        public ContactInfo custContact;
    }
    public class Branch
    {
        public string name;
        public Address branchAdd;
        public ContactInfo branchContact;
    }
}

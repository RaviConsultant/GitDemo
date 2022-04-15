
namespace IBank.Utility
{

    public class Address
    {
        public string Street;
        public string Area;
        public string City;
        public string Zip;
    }
    public class ContactInfo
    {
        public string phone;
        public string mobile;
        public string email;
    }
    public class Customer
    {
        public string FirstName;
        public string LastName;
        Address custAdd;
        ContactInfo custContact;
    }
    public class Branch
    {
        public string Name;
        Address branchAdd;
        ContactInfo branchContact;
    }

}
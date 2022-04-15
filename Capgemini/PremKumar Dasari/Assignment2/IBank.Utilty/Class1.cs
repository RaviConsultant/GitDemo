
namespace IBank.Utility
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        Address CustAdd;
        ContactInfo CustContact;
    }
    public class Address
    {
        public string Street;
        public string Area;
        public string City;
        public string Zip;
    }
    public class ContactInfo
    {
        public string Phone;
        public string Mobile;
        public string Email;
    }

    public class Branch
    {
        public string Name;
        Address BranchAdd;
        ContactInfo BranchContact;
    }

}
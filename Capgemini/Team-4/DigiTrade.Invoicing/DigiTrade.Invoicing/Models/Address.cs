using System.ComponentModel.DataAnnotations;

namespace DigiTrade.Invoicing.Models
{
    public class Address
    {

        [Key]
        public int AddressId { get; set; }
        public string Building { get; set; }
        public string Stree { get; set; }
        public string Area { get; set; }
        public string ?City { get; set; }
        public string Zip
        {
            get; set;
        }
    }
}

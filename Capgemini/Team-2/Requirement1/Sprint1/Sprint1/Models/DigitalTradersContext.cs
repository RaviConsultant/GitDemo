using Microsoft.EntityFrameworkCore;

namespace Sprint1.Models
{
    public class DigitalTradersContext:DbContext
    {
        public DigitalTradersContext(DbContextOptions<DigitalTradersContext> options) : base(options)
        {
        }


        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesInvoice> SalesInvoice { get; set; }
    }
}

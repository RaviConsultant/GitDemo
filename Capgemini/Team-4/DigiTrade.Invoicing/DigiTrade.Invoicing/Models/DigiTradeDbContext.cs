using Microsoft.EntityFrameworkCore;

namespace DigiTrade.Invoicing.Models
{
    public class DigiTradeDbContext:DbContext
    {
        public DigiTradeDbContext(DbContextOptions<DigiTradeDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<SaleInvoice> SaleInvoices { get; set; }


    }
}

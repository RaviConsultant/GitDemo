using DigiTradeASP.NETWEBAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace DigiTradeMVC.NET.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<SalesInvoice> SaleInvoices { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}

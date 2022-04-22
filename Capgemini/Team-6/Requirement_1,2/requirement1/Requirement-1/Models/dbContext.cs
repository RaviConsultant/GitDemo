using Microsoft.EntityFrameworkCore;

namespace Requirement_1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
            public DbSet<Customer> Customer { get; set; }
            public DbSet<Brand> Brand { get; set; }
            public DbSet<Product> Product { get; set; }
            public DbSet<SalesInvoice> SalesInvoice { get; set; }
        }
     }


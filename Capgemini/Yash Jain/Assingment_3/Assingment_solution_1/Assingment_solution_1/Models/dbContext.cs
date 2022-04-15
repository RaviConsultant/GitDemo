using Microsoft.EntityFrameworkCore;

namespace Assingment_solution_1.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }
        public DbSet<CustCategory> CustCategory { get; set; }
        public DbSet<Customer> Customer{ get; set; }
    }
}

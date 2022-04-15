using CustomerAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerAssignment.DataAccess
{
    public class CustomerDbContext : DbContext
    {
        //public CustomerDbContext(CustomerDbContext<>)
        //{

        //}

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }

        public DbSet<CustomerModel> Customers
        {
            get; set;
        }

        public DbSet<CustomerCategoryModel> CustCategory
        {
            get; set;
        }

    }
}
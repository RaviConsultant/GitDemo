using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Requirement.Data.Models
{
    public partial class NewContext : DbContext
    {
        public NewContext()
        {
        }

        public NewContext(DbContextOptions<NewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(" Server=localhost; Database=New; Trusted_Connection = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.ProductTitle)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("Product_title");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("Customer_Email");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Customer_phone");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ProductTitle)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("Product_title");

                entity.Property(e => e.SalePrice).HasColumnName("Sale_Price");
            });

            modelBuilder.Entity<SalesInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceNum);

                entity.Property(e => e.InvoiceNum).HasColumnName("Invoice_Num");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.InvoiceDate).HasColumnName("Invoice_Date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

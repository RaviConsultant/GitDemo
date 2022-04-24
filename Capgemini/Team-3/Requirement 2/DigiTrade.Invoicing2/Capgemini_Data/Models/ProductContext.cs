using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Capgemini_Data.Models
{
    public partial class ProductContext : DbContext
    {
        public ProductContext()
        {
        }

        public ProductContext(DbContextOptions<ProductContext> options)
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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-IJU63PT3\\SQLEXPRESS; Database=Product; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.BrandId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Discription).HasMaxLength(64);

                entity.Property(e => e.Processor)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ProductTitle)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Ram).HasColumnName("RAM");

                entity.Property(e => e.Rom).HasColumnName("ROM");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId);
            });

            modelBuilder.Entity<SalesInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceNumber);

                entity.ToTable("Sales_Invoices");

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesInvoices)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesInvoices)
                    .HasForeignKey(d => d.ProductId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

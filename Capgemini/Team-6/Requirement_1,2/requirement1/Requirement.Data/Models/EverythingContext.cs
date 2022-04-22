using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Requirement.Data.Models
{
    public partial class EverythingContext : DbContext
    {
        public EverythingContext()
        {
        }

        public EverythingContext(DbContextOptions<EverythingContext> options)
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
                optionsBuilder.UseSqlServer("Server=localhost; Database=Everything; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("Brand_Name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(128);

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
                    .HasColumnName("Customer_Phone");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("Brand_Name");

                entity.Property(e => e.CurStock).HasColumnName("Cur_stock");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.Processor)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Ram).HasColumnName("RAM");

                entity.Property(e => e.Rom).HasColumnName("ROM");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<SalesInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceNumber);

                entity.ToTable("SalesInvoice");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

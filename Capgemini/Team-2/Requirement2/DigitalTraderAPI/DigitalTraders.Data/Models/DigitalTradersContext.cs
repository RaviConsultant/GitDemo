using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigitalTraders.Data.Models
{
    public partial class DigitalTradersContext : DbContext
    {
        public DigitalTradersContext()
        {
        }

        public DigitalTradersContext(DbContextOptions<DigitalTradersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<SalesInvoice> SalesInvoice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost; Database=DigitalTraders; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>(entity =>
            {
                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.Area).IsRequired();

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HouseNum).IsRequired();

                entity.Property(e => e.Street).IsRequired();

                entity.Property(e => e.Zip).IsRequired();
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.BrandId);

                entity.Property(e => e.Processor)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProductTitle)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Rom).HasColumnName("ROM");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId);
                
               
            });

            modelBuilder.Entity<SalesInvoice>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesInvoice)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesInvoice)
                    .HasForeignKey(d => d.ProductId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

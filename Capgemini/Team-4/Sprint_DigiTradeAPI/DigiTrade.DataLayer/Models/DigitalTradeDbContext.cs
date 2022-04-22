using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.DataLayer.Models
{
    public partial class DigitalTradeDbContext : DbContext
    {
        public DigitalTradeDbContext()
        {
        }

        public DigitalTradeDbContext(DbContextOptions<DigitalTradeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<SaleInvoices> SaleInvoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost; Database=DigitalTradeDb; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);
            });

            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasIndex(e => e.AddressId);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AddressId);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.HasIndex(e => e.BrandId);

                entity.Property(e => e.Battery)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CurrentStock).HasColumnName("Current_Stock");

                entity.Property(e => e.FrontCamera)
                    .IsRequired()
                    .HasColumnName("Front_Camera")
                    .HasMaxLength(60);

                entity.Property(e => e.PrimaryCamera)
                    .IsRequired()
                    .HasColumnName("Primary_Camera")
                    .HasMaxLength(60);

                entity.Property(e => e.Processor)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Ram)
                    .IsRequired()
                    .HasColumnName("RAM")
                    .HasMaxLength(60);

                entity.Property(e => e.Rom)
                    .IsRequired()
                    .HasColumnName("ROM")
                    .HasMaxLength(60);

                entity.Property(e => e.SalePrice).HasColumnName("Sale_Price");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId);
            });

            modelBuilder.Entity<SaleInvoices>(entity =>
            {
                entity.HasKey(e => e.InvoiceNumber);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ProductId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleInvoices)
                    .HasForeignKey(d => d.CustomerId);

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.SaleInvoices)
                //    .HasForeignKey(d => d.ProductId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

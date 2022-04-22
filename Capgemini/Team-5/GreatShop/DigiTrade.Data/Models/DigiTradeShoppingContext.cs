using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Data.Models
{
    public partial class DigiTradeShoppingContext : DbContext
    {
        public DigiTradeShoppingContext()
        {
        }

        public DigiTradeShoppingContext(DbContextOptions<DigiTradeShoppingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<SaleInvoices> SaleInvoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost; Database=DigiTradeShopping; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Area).IsRequired();

                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.Street).IsRequired();

                entity.Property(e => e.Zip).IsRequired();
            });

            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.Property(e => e.BrandId).HasColumnName("Brand_Id");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.HasIndex(e => e.AddressId);

                entity.Property(e => e.CustId).HasColumnName("Cust_Id");

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AddressId);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.HasIndex(e => e.BrandId);

                entity.Property(e => e.ProdId).HasColumnName("Prod_Id");

                entity.Property(e => e.Battery).IsRequired();

                entity.Property(e => e.BrandId).HasColumnName("Brand_Id");

                entity.Property(e => e.CurrentStock).HasColumnName("Current_Stock");

                entity.Property(e => e.FrontCam)
                    .IsRequired()
                    .HasColumnName("Front_cam");

                entity.Property(e => e.PrimaryCam)
                    .IsRequired()
                    .HasColumnName("Primary_cam");

                entity.Property(e => e.Processor).IsRequired();

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Ram).IsRequired();

                entity.Property(e => e.Rom).IsRequired();

                entity.Property(e => e.SalesPrice).HasColumnName("Sales_Price");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId);
            });

            modelBuilder.Entity<SaleInvoices>(entity =>
            {
                entity.HasKey(e => e.InvoiceNo);

                entity.HasIndex(e => e.CustId);

                entity.HasIndex(e => e.ProdId);

                entity.Property(e => e.CustId).HasColumnName("Cust_Id");

                entity.Property(e => e.ProdId).HasColumnName("Prod_Id");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.SaleInvoices)
                    .HasForeignKey(d => d.CustId);

                //entity.HasOne(d => d.Prod)
                //    .WithMany(p => p.SaleInvoices)
                //    .HasForeignKey(d => d.ProdId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

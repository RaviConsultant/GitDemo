using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DigiTrade.Data.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
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
                optionsBuilder.UseSqlServer("Server=MUG; Database=DB; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasColumnName("Brand_Name")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustAddress)
                    .IsRequired()
                    .HasColumnName("Cust_Address")
                    .HasMaxLength(128);

                entity.Property(e => e.CustEmail)
                    .IsRequired()
                    .HasColumnName("Cust_Email")
                    .HasMaxLength(128);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasColumnName("Cust_Name")
                    .HasMaxLength(128);

                entity.Property(e => e.CustPhone)
                    .IsRequired()
                    .HasColumnName("Cust_Phone")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.BrandId);

                entity.Property(e => e.Battery).HasColumnName("battery");

                entity.Property(e => e.CurStock).HasColumnName("cur_stock");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.FrontCam).HasColumnName("front_cam");

                entity.Property(e => e.PrimaryCam).HasColumnName("primary_cam");

                entity.Property(e => e.Processor)
                    .IsRequired()
                    .HasColumnName("processor")
                    .HasMaxLength(128);

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(128);

                //entity.HasOne(d => d.Brand)
                //    .WithMany(p => p.Products)
                //    .HasForeignKey(d => d.BrandId);
            });

            modelBuilder.Entity<SalesInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceNum);

                entity.HasIndex(e => e.CustId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.InvoiceNum).HasColumnName("Invoice_num");

                entity.Property(e => e.CustId).HasColumnName("Cust_ID");

                entity.Property(e => e.InvoiceDate).HasColumnName("Invoice_Date");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.SalesInvoices)
                    .HasForeignKey(d => d.CustId);

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.SalesInvoices)
                //    .HasForeignKey(d => d.ProductId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

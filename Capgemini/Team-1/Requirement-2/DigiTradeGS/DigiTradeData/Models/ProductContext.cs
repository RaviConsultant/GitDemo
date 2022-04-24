using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DigiTradeData.Models
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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost; Database=Product; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

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
                entity.HasIndex(e => e.BrandId, "IX_Products_BrandID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");
                entity.Property(e => e.SalePrice).HasColumnName("SalePrice");

                entity.Property(e => e.Cur_Stock).HasColumnName("cur_Stock");
                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.Description).HasMaxLength(64);

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

                entity.HasIndex(e => e.CustomerId, "IX_Sales_Invoices_CustomerID");

                entity.HasIndex(e => e.ProductId, "IX_Sales_Invoices_ProductID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesInvoices)
                    .HasForeignKey(d => d.CustomerId);

                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

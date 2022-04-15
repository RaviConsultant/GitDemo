using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class CapgeminiContext : DbContext
    {
        //public CapgeminiContext()
        //{
        //}

        public CapgeminiContext(DbContextOptions<CapgeminiContext> options) : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Pay> Pay { get; set; }
        public virtual DbSet<Payslip> Payslip { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SalesDetail> SalesDetail { get; set; }
        public virtual DbSet<SalesHead> SalesHead { get; set; }
        public virtual DbSet<StudSubject> StudSubject { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<ViewEmp> ViewEmp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=localhost; Database=Capgemini; Trusted_Connection=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.FirstName)
                    .HasName("idx_Cust_FirstName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("Emp_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_Emp_Dept");
            });

            modelBuilder.Entity<Pay>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BasicPay).HasColumnName("Basic_Pay");

                entity.Property(e => e.EmpId).HasColumnName("Emp_ID");

                entity.Property(e => e.PayMonth).HasColumnName("Pay_Month");

                entity.Property(e => e.PayYear).HasColumnName("Pay_Year");

                entity.Property(e => e.SpecialPay).HasColumnName("Special_Pay");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Pay)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pay_Emp");
            });

            modelBuilder.Entity<Payslip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Payslip");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("emp_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Title)
                    .HasName("UQ__Product__2CB664DC08F7E8E3")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurStock).HasColumnName("Cur_Stock");

                entity.Property(e => e.SalePrice).HasColumnName("Sale_Price");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.SalesDetail)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK_SalesDetails_Prod");
            });

            modelBuilder.Entity<SalesHead>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.InvDate).HasColumnType("date");

                entity.Property(e => e.InvNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.SalesHead)
                    .HasForeignKey(d => d.CustId)
                    .HasConstraintName("FK_SalesHead_Cust");
            });

            modelBuilder.Entity<StudSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StudSubject", "stud");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.SubId).HasColumnName("SubID");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student", "stud");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Subject", "stud");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewEmp");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("Emp_ID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

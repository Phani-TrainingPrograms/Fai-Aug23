using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proj1BasicApp.Data;

public partial class FaiTrainingContext : DbContext
{
    public FaiTrainingContext()
    {
    }

    public FaiTrainingContext(DbContextOptions<FaiTrainingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CstTable> CstTables { get; set; }

    public virtual DbSet<CustomerAudit> CustomerAudits { get; set; }

    public virtual DbSet<DeptTable> DeptTables { get; set; }

    public virtual DbSet<Emptable> Emptables { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TblBook> TblBooks { get; set; }

    public virtual DbSet<UserTable> UserTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=FaiTraining; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CstTable>(entity =>
        {
            entity.HasKey(e => e.CstId).HasName("PK__CstTable__E2804E6FDB3CB763");

            entity.ToTable("CstTable", tb =>
                {
                    tb.HasTrigger("OnInsertCustomer");
                    tb.HasTrigger("OnUpdateCustomer");
                });

            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BillDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.CstAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CstName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerAudit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3213E83FDF600B00");

            entity.ToTable("Customer_Audit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Details)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("details");
        });

        modelBuilder.Entity<DeptTable>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__DeptTabl__014881AE2C2300BB");

            entity.ToTable("DeptTable");

            entity.Property(e => e.DeptName).HasMaxLength(50);
        });

        modelBuilder.Entity<Emptable>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Emptable__AFB3EC0D847DFA9D");

            entity.ToTable("Emptable");

            entity.Property(e => e.EmpId).HasColumnName("empId");
            entity.Property(e => e.EmpAddress)
                .HasMaxLength(200)
                .HasColumnName("empAddress");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .HasColumnName("empName");
            entity.Property(e => e.EmpSalary)
                .HasColumnType("money")
                .HasColumnName("empSalary");

            entity.HasOne(d => d.Dept).WithMany(p => p.Emptables)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK__Emptable__DeptId__267ABA7A");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CD96D74B68");

            entity.ToTable("Product");

            entity.Property(e => e.ProductImage).IsUnicode(false);
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductPrice).HasColumnType("money");
            entity.Property(e => e.StockCount).HasDefaultValueSql("((100))");
        });

        modelBuilder.Entity<TblBook>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.ToTable("tblBook");
        });

        modelBuilder.Entity<UserTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserTabl__3214EC07166E6D13");

            entity.ToTable("UserTable");

            entity.HasIndex(e => e.Username, "UQ__UserTabl__536C85E4BC6774AB").IsUnique();

            entity.Property(e => e.Expiry)
                .HasColumnType("datetime")
                .HasColumnName("expiry");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

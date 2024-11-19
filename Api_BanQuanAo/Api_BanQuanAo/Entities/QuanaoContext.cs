using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Api_BanQuanAo.Entities;

public partial class QuanaoContext : DbContext
{
    public QuanaoContext()
    {
    }

    public QuanaoContext(DbContextOptions<QuanaoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Orderdetail> Orderdetails { get; set; }

    public virtual DbSet<Orderpro> Orderpros { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;database=quanao", Microsoft.EntityFrameworkCore.ServerVersion.Parse("11.3.2-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("category")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .HasColumnName("categoryName");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("customer")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Orderdetail>(entity =>
        {
            entity.HasKey(e => e.CartItemId).HasName("PRIMARY");

            entity
                .ToTable("orderdetail")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.CartId, "cartId");

            entity.Property(e => e.CartItemId)
                .HasMaxLength(50)
                .HasDefaultValueSql("'AUTO_INCREMENT'")
                .HasColumnName("cartItemId");
            entity.Property(e => e.CartId)
                .HasMaxLength(50)
                .HasColumnName("cartId");
            entity.Property(e => e.Price)
                .HasPrecision(10, 2)
                .HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .HasColumnName("productId");
            entity.Property(e => e.Quantity)
                .HasColumnType("int(11)")
                .HasColumnName("quantity");
        });

        modelBuilder.Entity<Orderpro>(entity =>
        {
            entity.HasKey(e => e.CartId).HasName("PRIMARY");

            entity
                .ToTable("orderpro")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.CartId)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'")
                .HasColumnName("cartId");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnName("dateCreated");
            entity.Property(e => e.Methodpayment)
                .HasMaxLength(20)
                .HasColumnName("methodpayment");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.TotalPrice)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("totalPrice");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("userId");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("product")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Brand)
                .HasMaxLength(30)
                .HasColumnName("brand");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .HasColumnName("category");
            entity.Property(e => e.Description)
                .HasMaxLength(877)
                .HasColumnName("description");
            entity.Property(e => e.DiscountedPercentage)
                .HasColumnType("int(11)")
                .HasColumnName("discountedPercentage");
            entity.Property(e => e.Images)
                .HasMaxLength(300)
                .HasColumnName("images");
            entity.Property(e => e.Price)
                .HasColumnType("int(11)")
                .HasColumnName("price");
            entity.Property(e => e.Rating)
                .HasPrecision(3, 1)
                .HasColumnName("rating");
            entity.Property(e => e.Stock)
                .HasColumnType("int(11)")
                .HasColumnName("stock");
            entity.Property(e => e.Title)
                .HasMaxLength(106)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

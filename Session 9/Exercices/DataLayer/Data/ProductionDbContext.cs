using System;
using System.Collections.Generic;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data;

public partial class ProductionDbContext : DbContext
{
    public ProductionDbContext()
    {
    }

    public ProductionDbContext(DbContextOptions<ProductionDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Eric\\Desktop\\IDEC_Repo\\Session 9\\Exercices\\DataLayer\\Production.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC2765D760F4");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Login).IsRequired();
            entity.Property(e => e.Password).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

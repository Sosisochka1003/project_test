using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace test1;

public partial class PostgresContext : DbContext
{
    public DbSet<Country> countries { get; set; }
    public DbSet<Customer> customers { get; set; }
    public DbSet<Employee> employees { get; set; }
    public DbSet<Hotel> hotels { get; set; }
    public DbSet<Sale> sales { get; set; }
    public DbSet<Tour> tours { get; set; }

    public PostgresContext()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();

    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test;Username=postgres;Password=1003");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasKey(u => u.Id).HasName("CountryPrimaryKey");
        modelBuilder.Entity<Customer>().HasKey(u => u.Id).HasName("CustomerPrimaryKey");
        modelBuilder.Entity<Employee>().HasKey(u => u.Id).HasName("EmployeePrimaryKey");
        modelBuilder.Entity<Hotel>().HasKey(u => u.Id).HasName("HotelPrimaryKey");
        modelBuilder.Entity<Sale>().HasKey(u => u.Id).HasName("SalePrimaryKey");
        modelBuilder.Entity<Tour>().HasKey(u => u.Id).HasName("TourPrimaryKey");
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

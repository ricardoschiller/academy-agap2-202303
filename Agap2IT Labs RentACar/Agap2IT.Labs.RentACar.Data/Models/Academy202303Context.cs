using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Agap2IT.Labs.RentACar.Data.Models;

public partial class Academy202303Context : DbContext
{
    public Academy202303Context()
    {
    }

    public Academy202303Context(DbContextOptions<Academy202303Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<ModelColor> ModelColors { get; set; }

    public virtual DbSet<Rent> Rents { get; set; }

    public virtual DbSet<Renting> Rentings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:academies-moongy.database.windows.net,1433;Database=academy-2023-03;User Id=appadmin; Password=qwert#4477;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.Brand)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.License)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Color).WithMany(p => p.Cars)
                .HasForeignKey(d => d.ColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cars_Colors");

            entity.HasOne(d => d.Model).WithMany(p => p.Cars)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cars_Models");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Cellphone)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LicenseNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Nif)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Cellphone)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Nif)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .IsFixedLength();
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ModelColor>(entity =>
        {
            entity.HasOne(d => d.Color).WithMany(p => p.ModelColors)
                .HasForeignKey(d => d.ColorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ModelColors_Colors");

            entity.HasOne(d => d.Model).WithMany(p => p.ModelColors)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ModelColors_Models");
        });

        modelBuilder.Entity<Rent>(entity =>
        {
            entity.Property(e => e.FinishDate).HasPrecision(3);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.StartDate).HasPrecision(3);

            entity.HasOne(d => d.Car).WithMany(p => p.Rents)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rents_Cars");

            entity.HasOne(d => d.Client).WithMany(p => p.Rents)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rents_Clients");
        });

        modelBuilder.Entity<Renting>(entity =>
        {
            entity.ToTable("Renting");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

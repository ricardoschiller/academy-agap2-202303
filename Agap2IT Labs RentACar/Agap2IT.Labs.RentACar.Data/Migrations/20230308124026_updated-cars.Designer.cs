﻿// <auto-generated />
using System;
using Agap2IT.Labs.RentACar.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agap2IT.Labs.RentACar.Data.Migrations
{
    [DbContext(typeof(Academy202303Context))]
    [Migration("20230308124026_updated-cars")]
    partial class updatedcars
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("BuildDate")
                        .HasPrecision(3)
                        .HasColumnType("datetime2(3)");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("License")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .IsFixedLength();

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2000)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ModelId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cellphone")
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("char(9)")
                        .IsFixedLength();

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nif")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cellphone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("char(9)")
                        .IsFixedLength();

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nif")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .IsFixedLength();

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("binary(32)")
                        .IsFixedLength();

                    b.Property<Guid>("Salt")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.ModelColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ModelId");

                    b.ToTable("ModelColors");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FinishDate")
                        .HasPrecision(3)
                        .HasColumnType("datetime2(3)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.Property<DateTime>("StartDate")
                        .HasPrecision(3)
                        .HasColumnType("datetime2(3)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Renting", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Renting", (string)null);
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Car", b =>
                {
                    b.HasOne("Agap2IT.Labs.RentACar.Data.Models.Color", "Color")
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .IsRequired()
                        .HasConstraintName("FK_Cars_Colors");

                    b.HasOne("Agap2IT.Labs.RentACar.Data.Models.Model", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelId")
                        .IsRequired()
                        .HasConstraintName("FK_Cars_Models");

                    b.Navigation("Color");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.ModelColor", b =>
                {
                    b.HasOne("Agap2IT.Labs.RentACar.Data.Models.Color", "Color")
                        .WithMany("ModelColors")
                        .HasForeignKey("ColorId")
                        .IsRequired()
                        .HasConstraintName("FK_ModelColors_Colors");

                    b.HasOne("Agap2IT.Labs.RentACar.Data.Models.Model", "Model")
                        .WithMany("ModelColors")
                        .HasForeignKey("ModelId")
                        .IsRequired()
                        .HasConstraintName("FK_ModelColors_Models");

                    b.Navigation("Color");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Rent", b =>
                {
                    b.HasOne("Agap2IT.Labs.RentACar.Data.Models.Car", "Car")
                        .WithMany("Rents")
                        .HasForeignKey("CarId")
                        .IsRequired()
                        .HasConstraintName("FK_Rents_Cars");

                    b.HasOne("Agap2IT.Labs.RentACar.Data.Models.Client", "Client")
                        .WithMany("Rents")
                        .HasForeignKey("ClientId")
                        .IsRequired()
                        .HasConstraintName("FK_Rents_Clients");

                    b.Navigation("Car");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Car", b =>
                {
                    b.Navigation("Rents");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Client", b =>
                {
                    b.Navigation("Rents");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Color", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("ModelColors");
                });

            modelBuilder.Entity("Agap2IT.Labs.RentACar.Data.Models.Model", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("ModelColors");
                });
#pragma warning restore 612, 618
        }
    }
}

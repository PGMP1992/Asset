﻿// <auto-generated />
using System;
using Asset;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asset.Migrations
{
    [DbContext(typeof(DBCAsset))]
    [Migration("20240409092144_deleteAssetfromTables")]
    partial class deleteAssetfromTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Asset.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("DollarRate")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DollarRate = 0.10000000000000001,
                            Name = "Sweden",
                            ShortName = "SEK"
                        },
                        new
                        {
                            Id = 2,
                            DollarRate = 1.1000000000000001,
                            Name = "Spain",
                            ShortName = "EUR"
                        },
                        new
                        {
                            Id = 3,
                            DollarRate = 1.0,
                            Name = "USA",
                            ShortName = "USD"
                        },
                        new
                        {
                            Id = 4,
                            DollarRate = 0.14000000000000001,
                            Name = "Denmark",
                            ShortName = "DKK"
                        },
                        new
                        {
                            Id = 5,
                            DollarRate = 1.2,
                            Name = "Great Britain",
                            ShortName = "GBP"
                        });
                });

            modelBuilder.Entity("Asset.MyAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            ProductId = 1,
                            PurchaseDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            ProductId = 2,
                            PurchaseDate = new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            ProductId = 3,
                            PurchaseDate = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            ProductId = 4,
                            PurchaseDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 2,
                            ProductId = 5,
                            PurchaseDate = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 2,
                            ProductId = 6,
                            PurchaseDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 2,
                            ProductId = 1,
                            PurchaseDate = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 2,
                            ProductId = 2,
                            PurchaseDate = new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 3,
                            ProductId = 3,
                            PurchaseDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 3,
                            ProductId = 4,
                            PurchaseDate = new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 3,
                            ProductId = 1,
                            PurchaseDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 4,
                            ProductId = 2,
                            PurchaseDate = new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            CountryId = 4,
                            ProductId = 3,
                            PurchaseDate = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            CountryId = 4,
                            ProductId = 4,
                            PurchaseDate = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            CountryId = 4,
                            ProductId = 5,
                            PurchaseDate = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            CountryId = 5,
                            ProductId = 6,
                            PurchaseDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17,
                            CountryId = 5,
                            ProductId = 1,
                            PurchaseDate = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18,
                            CountryId = 5,
                            ProductId = 2,
                            PurchaseDate = new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19,
                            CountryId = 5,
                            ProductId = 3,
                            PurchaseDate = new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20,
                            CountryId = 5,
                            ProductId = 4,
                            PurchaseDate = new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Asset.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Apple",
                            Model = "iBook 1.0",
                            Price = 1500.0,
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Apple",
                            Model = "iPhone 8.0",
                            Price = 1000.0,
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Samsung",
                            Model = "Galaxy 53",
                            Price = 1500.0,
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Samsung",
                            Model = "Pad 8.0",
                            Price = 1000.0,
                            Type = "Tab"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Google",
                            Model = "Chrome Phone",
                            Price = 1500.0,
                            Type = "Phone"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Google",
                            Model = "Chrome Book",
                            Price = 1000.0,
                            Type = "Laptop"
                        });
                });

            modelBuilder.Entity("Asset.MyAsset", b =>
                {
                    b.HasOne("Asset.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asset.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}

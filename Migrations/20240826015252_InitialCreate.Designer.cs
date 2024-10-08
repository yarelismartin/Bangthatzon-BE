﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bangthatzon.Migrations
{
    [DbContext(typeof(BangthatzonDbContext))]
    [Migration("20240826015252_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bangthatzon.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Clothing"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Home & Kitchen"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Books"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Sports & Outdoors"
                        });
                });

            modelBuilder.Entity("Bangthatzon.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("OpenOrder")
                        .HasColumnType("boolean");

                    b.Property<int?>("PaymentTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OpenOrder = false,
                            PaymentTypeId = 4,
                            PurchaseDate = new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            OpenOrder = false,
                            PaymentTypeId = 1,
                            PurchaseDate = new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            OpenOrder = true,
                            PaymentTypeId = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            OpenOrder = true,
                            PaymentTypeId = 2,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Bangthatzon.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardNumber = "1234567812345678",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            CardNumber = "2345678923456789",
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            CardNumber = "3456789034567890",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            CardNumber = "4567890145678901",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Bangthatzon.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("QuantityAvailable")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Latest model with all the features",
                            Image = "smartphone.jpg",
                            Price = 699.99m,
                            ProductName = "Smartphone",
                            QuantityAvailable = 50,
                            SellerId = 4
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Brews coffee in minutes",
                            Image = "coffee_maker.jpg",
                            Price = 89.99m,
                            ProductName = "Coffee Maker",
                            QuantityAvailable = 20,
                            SellerId = 5
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Noise-cancelling over-ear headphones",
                            Image = "headphones.jpg",
                            Price = 149.99m,
                            ProductName = "Headphones",
                            QuantityAvailable = 30,
                            SellerId = 6
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "High-quality mat for yoga and workouts",
                            Image = "yoga_mat.jpg",
                            Price = 39.99m,
                            ProductName = "Yoga Mat",
                            QuantityAvailable = 40,
                            SellerId = 7
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Fast wireless charger for all devices",
                            Image = "wireless_charger.jpg",
                            Price = 29.99m,
                            ProductName = "Wireless Charger",
                            QuantityAvailable = 25,
                            SellerId = 8
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Durable tent for outdoor camping",
                            Image = "camping_tent.jpg",
                            Price = 119.99m,
                            ProductName = "Camping Tent",
                            QuantityAvailable = 15,
                            SellerId = 9
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Stylish smartwatch with fitness tracking",
                            Image = "smartwatch.jpg",
                            Price = 249.99m,
                            ProductName = "Smartwatch",
                            QuantityAvailable = 22,
                            SellerId = 10
                        });
                });

            modelBuilder.Entity("Bangthatzon.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Elm Street",
                            Email = "alice.smith@example.com",
                            FirstName = "Alice",
                            Image = "alice.jpg",
                            LastName = "Smith",
                            Uid = "user1",
                            Username = "alice.smith"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak Avenue",
                            Email = "bob.johnson@example.com",
                            FirstName = "Bob",
                            Image = "bob.jpg",
                            LastName = "Johnson",
                            Uid = "user2",
                            Username = "bob.johnson"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Pine Road",
                            Email = "charlie.brown@example.com",
                            FirstName = "Charlie",
                            Image = "charlie.jpg",
                            LastName = "Brown",
                            Uid = "user3",
                            Username = "charlie.brown"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Maple Lane",
                            Email = "diana.williams@example.com",
                            FirstName = "Diana",
                            Image = "diana.jpg",
                            LastName = "Williams",
                            Uid = "user4",
                            Username = "diana.williams"
                        },
                        new
                        {
                            Id = 5,
                            Address = "202 Birch Drive",
                            Email = "evan.jones@example.com",
                            FirstName = "Evan",
                            Image = "evan.jpg",
                            LastName = "Jones",
                            Uid = "user5",
                            Username = "evan.jones"
                        },
                        new
                        {
                            Id = 6,
                            Address = "303 Cedar Boulevard",
                            Email = "fiona.miller@example.com",
                            FirstName = "Fiona",
                            Image = "fiona.jpg",
                            LastName = "Miller",
                            Uid = "user6",
                            Username = "fiona.miller"
                        },
                        new
                        {
                            Id = 7,
                            Address = "404 Elm Street",
                            Email = "george.davis@example.com",
                            FirstName = "George",
                            Image = "george.jpg",
                            LastName = "Davis",
                            Uid = "user7",
                            Username = "george.davis"
                        },
                        new
                        {
                            Id = 8,
                            Address = "505 Oak Avenue",
                            Email = "hannah.wilson@example.com",
                            FirstName = "Hannah",
                            Image = "hannah.jpg",
                            LastName = "Wilson",
                            Uid = "user8",
                            Username = "hannah.wilson"
                        },
                        new
                        {
                            Id = 9,
                            Address = "606 Pine Road",
                            Email = "isaac.moore@example.com",
                            FirstName = "Isaac",
                            Image = "isaac.jpg",
                            LastName = "Moore",
                            Uid = "user9",
                            Username = "isaac.moore"
                        },
                        new
                        {
                            Id = 10,
                            Address = "707 Maple Lane",
                            Email = "jessica.taylor@example.com",
                            FirstName = "Jessica",
                            Image = "jessica.jpg",
                            LastName = "Taylor",
                            Uid = "user10",
                            Username = "jessica.taylor"
                        });
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Bangthatzon.Models.Order", b =>
                {
                    b.HasOne("Bangthatzon.Models.PaymentType", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId");

                    b.HasOne("Bangthatzon.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bangthatzon.Models.PaymentType", b =>
                {
                    b.HasOne("Bangthatzon.Models.User", "User")
                        .WithMany("PaymentTypes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bangthatzon.Models.Product", b =>
                {
                    b.HasOne("Bangthatzon.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangthatzon.Models.User", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("Bangthatzon.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangthatzon.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bangthatzon.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Bangthatzon.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("PaymentTypes");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

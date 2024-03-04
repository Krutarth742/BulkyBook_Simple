﻿// <auto-generated />
using BulkyBook.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyBook.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240215084340_AddForeignKeyToProductCategoryRelation")]
    partial class AddForeignKeyToProductCategoryRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulkyBook.Models.CategoryModel", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("CategoryOrder")
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action",
                            CategoryOrder = 1
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "SciFi",
                            CategoryOrder = 2
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Comics",
                            CategoryOrder = 3
                        });
                });

            modelBuilder.Entity("BulkyBook.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductListPrice")
                        .HasColumnType("float");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<double>("ProductPrice100")
                        .HasColumnType("float");

                    b.Property<double>("ProductPrice50")
                        .HasColumnType("float");

                    b.Property<string>("ProductTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 1,
                            ProductAuthor = "Billy Spark",
                            ProductDescription = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincProductIDunt. ",
                            ProductISBN = "SWD9999001",
                            ProductListPrice = 99.0,
                            ProductPrice = 90.0,
                            ProductPrice100 = 80.0,
                            ProductPrice50 = 85.0,
                            ProductTitle = "Fortune of Time"
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 1,
                            ProductAuthor = "Nancy Hoover",
                            ProductDescription = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincProductIDunt. ",
                            ProductISBN = "CAW777777701",
                            ProductListPrice = 40.0,
                            ProductPrice = 30.0,
                            ProductPrice100 = 20.0,
                            ProductPrice50 = 25.0,
                            ProductTitle = "Dark Skies"
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 1,
                            ProductAuthor = "Julian Button",
                            ProductDescription = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincProductIDunt. ",
                            ProductISBN = "RITO5555501",
                            ProductListPrice = 55.0,
                            ProductPrice = 50.0,
                            ProductPrice100 = 35.0,
                            ProductPrice50 = 40.0,
                            ProductTitle = "Vanish in the Sunset"
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 2,
                            ProductAuthor = "Abby Muscles",
                            ProductDescription = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincProductIDunt. ",
                            ProductISBN = "WS3333333301",
                            ProductListPrice = 70.0,
                            ProductPrice = 65.0,
                            ProductPrice100 = 55.0,
                            ProductPrice50 = 60.0,
                            ProductTitle = "Cotton Candy"
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 2,
                            ProductAuthor = "Ron Parker",
                            ProductDescription = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincProductIDunt. ",
                            ProductISBN = "SOTJ1111111101",
                            ProductListPrice = 30.0,
                            ProductPrice = 27.0,
                            ProductPrice100 = 20.0,
                            ProductPrice50 = 25.0,
                            ProductTitle = "Rock in the Ocean"
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 3,
                            ProductAuthor = "Laura Phantom",
                            ProductDescription = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincProductIDunt. ",
                            ProductISBN = "FOT000000001",
                            ProductListPrice = 25.0,
                            ProductPrice = 23.0,
                            ProductPrice100 = 20.0,
                            ProductPrice50 = 22.0,
                            ProductTitle = "Leaves and Wonders"
                        });
                });

            modelBuilder.Entity("BulkyBook.Models.ProductModel", b =>
                {
                    b.HasOne("BulkyBook.Models.CategoryModel", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

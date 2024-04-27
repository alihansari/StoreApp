﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Book"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Electronic"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            ImageUrl = "/images/1.jpg",
                            Price = 17000m,
                            ProductName = "Computer",
                            Summary = ""
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            ImageUrl = "/images/2.jpg",
                            Price = 1000m,
                            ProductName = "Keyboard",
                            Summary = ""
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ImageUrl = "/images/3.jpg",
                            Price = 500m,
                            ProductName = "Mouse",
                            Summary = ""
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ImageUrl = "/images/4.jpg",
                            Price = 7000m,
                            ProductName = "Monitor",
                            Summary = ""
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            ImageUrl = "/images/5.jpg",
                            Price = 17000m,
                            ProductName = "Deck",
                            Summary = ""
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            ImageUrl = "/images/6.jpg",
                            Price = 25m,
                            ProductName = "History",
                            Summary = ""
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            ImageUrl = "/images/7.jpg",
                            Price = 45m,
                            ProductName = "Hamlet",
                            Summary = ""
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

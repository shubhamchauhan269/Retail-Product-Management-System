﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductMicroservices.Context;

namespace ProductMicroservices.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20210626072938_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductMicroservices.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Some example text.",
                            Image_Name = "Iphone.jpg",
                            Name = "Iphone",
                            Price = 20000.0,
                            Rating = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "Some example text.",
                            Image_Name = "Bracelet.jpg",
                            Name = "Bracelet",
                            Price = 2000.0,
                            Rating = 3
                        },
                        new
                        {
                            Id = 3,
                            Description = "Some example text.",
                            Image_Name = "earphone.webp",
                            Name = "Earphone",
                            Price = 1500.0,
                            Rating = 4
                        },
                        new
                        {
                            Id = 4,
                            Description = "Some example text.",
                            Image_Name = "1.jfif",
                            Name = "Book",
                            Price = 1000.0,
                            Rating = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

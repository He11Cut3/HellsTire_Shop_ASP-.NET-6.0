﻿// <auto-generated />
using System;
using Hells_Tire.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hells_Tire.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231002155014_Initialss")]
    partial class Initialss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hells_Tire.Models.HellsTireCategory", b =>
                {
                    b.Property<long>("HellsTireCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("HellsTireCategoryID"), 1L, 1);

                    b.Property<string>("HellsTireCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HellsTireCategorySlug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HellsTireCategoryID");

                    b.ToTable("HellsTireCategories");
                });

            modelBuilder.Entity("Hells_Tire.Models.HellsTireProduct", b =>
                {
                    b.Property<long>("HellsTireProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("HellsTireProductID"), 1L, 1);

                    b.Property<long>("HellsTireCategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("HellsTireProductBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HellsTireProductDescriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("HellsTireProductImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("HellsTireProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HellsTireProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HellsTireProductSlug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HellsTireProductID");

                    b.HasIndex("HellsTireCategoryID");

                    b.ToTable("HellsTireProducts");
                });

            modelBuilder.Entity("Hells_Tire.Models.HellsTireProduct", b =>
                {
                    b.HasOne("Hells_Tire.Models.HellsTireCategory", "HellsTireCategory")
                        .WithMany()
                        .HasForeignKey("HellsTireCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HellsTireCategory");
                });
#pragma warning restore 612, 618
        }
    }
}

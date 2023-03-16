﻿// <auto-generated />
using System;
using Ecommerce.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230311065951_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ecommerce.Domain.Entities.AttributeOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("AttributeOption");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.AttributeValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AttributeOptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttributeOptionId");

                    b.ToTable("AttributeValue");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.ProductVariant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AttributeOptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AttributeValueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttributeOptionId");

                    b.HasIndex("AttributeValueId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductVariant");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.UploadFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("UploadFiles");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.AttributeOption", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Product", "Product")
                        .WithMany("AttributeOption")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.AttributeValue", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.AttributeOption", "AttributeOption")
                        .WithMany("AttributeValue")
                        .HasForeignKey("AttributeOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AttributeOption");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Product", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.ProductVariant", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.AttributeOption", "AttributeOption")
                        .WithMany()
                        .HasForeignKey("AttributeOptionId");

                    b.HasOne("Ecommerce.Domain.Entities.AttributeValue", "AttributeValue")
                        .WithMany("ProductVariant")
                        .HasForeignKey("AttributeValueId");

                    b.HasOne("Ecommerce.Domain.Entities.Product", "Product")
                        .WithMany("ProductVariant")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AttributeOption");

                    b.Navigation("AttributeValue");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.UploadFile", b =>
                {
                    b.HasOne("Ecommerce.Domain.Entities.Product", "Product")
                        .WithMany("UploadFile")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.AttributeOption", b =>
                {
                    b.Navigation("AttributeValue");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.AttributeValue", b =>
                {
                    b.Navigation("ProductVariant");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Ecommerce.Domain.Entities.Product", b =>
                {
                    b.Navigation("AttributeOption");

                    b.Navigation("ProductVariant");

                    b.Navigation("UploadFile");
                });
#pragma warning restore 612, 618
        }
    }
}

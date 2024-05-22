﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Catalog.Persistence.EntityFramework;

#nullable disable

namespace Shop.Catalog.Persistence.EntityFramework.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    [Migration("20240521172449_AddRowVersionToProduct")]
    partial class AddRowVersionToProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Shop.Catalog.Domain.Categories.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long>("ParentCategoryId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Category", "catalog");
                });

            modelBuilder.Entity("Shop.Catalog.Domain.ParentCategories.ParentCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("ParentCategory", "catalog");
                });

            modelBuilder.Entity("Shop.Catalog.Domain.Categories.Category", b =>
                {
                    b.HasOne("Shop.Catalog.Domain.ParentCategories.ParentCategory", "ParentCategory")
                        .WithMany("Categories")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Shop.Catalog.Domain.Categories.ValueObjects.Description", "Description", b1 =>
                        {
                            b1.Property<long>("CategoryId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(4000)
                                .HasColumnType("NVarChar(4000)")
                                .HasColumnName("Description");

                            b1.HasKey("CategoryId");

                            b1.ToTable("Category", "catalog");

                            b1.WithOwner()
                                .HasForeignKey("CategoryId");
                        });

                    b.OwnsOne("Shop.Catalog.Domain.Categories.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<long>("CategoryId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("NVarChar(200)")
                                .HasColumnName("Name");

                            b1.HasKey("CategoryId");

                            b1.ToTable("Category", "catalog");

                            b1.WithOwner()
                                .HasForeignKey("CategoryId");
                        });

                    b.Navigation("Description");

                    b.Navigation("Name")
                        .IsRequired();

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Shop.Catalog.Domain.ParentCategories.ParentCategory", b =>
                {
                    b.OwnsOne("Shop.Catalog.Domain.ParentCategories.ValueObjects.Description", "Description", b1 =>
                        {
                            b1.Property<long>("ParentCategoryId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(4000)
                                .HasColumnType("NVarChar(4000)")
                                .HasColumnName("Description");

                            b1.HasKey("ParentCategoryId");

                            b1.ToTable("ParentCategory", "catalog");

                            b1.WithOwner()
                                .HasForeignKey("ParentCategoryId");
                        });

                    b.OwnsOne("Shop.Catalog.Domain.ParentCategories.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<long>("ParentCategoryId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("NVarChar(200)")
                                .HasColumnName("Name");

                            b1.HasKey("ParentCategoryId");

                            b1.ToTable("ParentCategory", "catalog");

                            b1.WithOwner()
                                .HasForeignKey("ParentCategoryId");
                        });

                    b.Navigation("Description");

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.Catalog.Domain.ParentCategories.ParentCategory", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}

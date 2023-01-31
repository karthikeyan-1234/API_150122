﻿// <auto-generated />
using System;
using API_150122.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_150122.Migrations
{
    [DbContext(typeof(BusinessDBContext))]
    [Migration("20230117053434_Intial Migration")]
    partial class IntialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_150122.Models.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobile_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("API_150122.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Item_Type_objid")
                        .HasColumnType("int");

                    b.Property<int?>("Uom_objid")
                        .HasColumnType("int");

                    b.Property<int>("item_type_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("uom_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Item_Type_objid");

                    b.HasIndex("Uom_objid");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("API_150122.Models.Item_Type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Item_Types");
                });

            modelBuilder.Entity("API_150122.Models.Purchase", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Vendor_objid")
                        .HasColumnType("int");

                    b.Property<string>("bill_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date_of_purchase")
                        .HasColumnType("datetime2");

                    b.Property<int>("vendor_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Vendor_objid");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("API_150122.Models.Purchase_Entry", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Purchase_objid")
                        .HasColumnType("int");

                    b.Property<int>("item_id")
                        .HasColumnType("int");

                    b.Property<int>("purchase_id")
                        .HasColumnType("int");

                    b.Property<double>("qty")
                        .HasColumnType("float");

                    b.Property<double>("rate")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("Purchase_objid");

                    b.ToTable("Purchase_Entries");
                });

            modelBuilder.Entity("API_150122.Models.Sale", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Customer_objid")
                        .HasColumnType("int");

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_of_sale")
                        .HasColumnType("datetime2");

                    b.Property<string>("sale_no")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Customer_objid");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("API_150122.Models.Sale_Entry", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("Sale_objid")
                        .HasColumnType("int");

                    b.Property<int>("item_id")
                        .HasColumnType("int");

                    b.Property<double>("qty")
                        .HasColumnType("float");

                    b.Property<double>("rate")
                        .HasColumnType("float");

                    b.Property<int>("sale_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Sale_objid");

                    b.ToTable("Sale_Entries");
                });

            modelBuilder.Entity("API_150122.Models.Uom", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Uoms");
                });

            modelBuilder.Entity("API_150122.Models.Vendor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("API_150122.Models.Item", b =>
                {
                    b.HasOne("API_150122.Models.Item_Type", "Item_Type_obj")
                        .WithMany("Item_objs")
                        .HasForeignKey("Item_Type_objid");

                    b.HasOne("API_150122.Models.Uom", "Uom_obj")
                        .WithMany("Item_objs")
                        .HasForeignKey("Uom_objid");

                    b.Navigation("Item_Type_obj");

                    b.Navigation("Uom_obj");
                });

            modelBuilder.Entity("API_150122.Models.Purchase", b =>
                {
                    b.HasOne("API_150122.Models.Vendor", "Vendor_obj")
                        .WithMany("Purchases")
                        .HasForeignKey("Vendor_objid");

                    b.Navigation("Vendor_obj");
                });

            modelBuilder.Entity("API_150122.Models.Purchase_Entry", b =>
                {
                    b.HasOne("API_150122.Models.Purchase", "Purchase_obj")
                        .WithMany("Purchase_Entries")
                        .HasForeignKey("Purchase_objid");

                    b.Navigation("Purchase_obj");
                });

            modelBuilder.Entity("API_150122.Models.Sale", b =>
                {
                    b.HasOne("API_150122.Models.Customer", "Customer_obj")
                        .WithMany("Sales")
                        .HasForeignKey("Customer_objid");

                    b.Navigation("Customer_obj");
                });

            modelBuilder.Entity("API_150122.Models.Sale_Entry", b =>
                {
                    b.HasOne("API_150122.Models.Sale", "Sale_obj")
                        .WithMany("Sale_Entries")
                        .HasForeignKey("Sale_objid");

                    b.Navigation("Sale_obj");
                });

            modelBuilder.Entity("API_150122.Models.Customer", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("API_150122.Models.Item_Type", b =>
                {
                    b.Navigation("Item_objs");
                });

            modelBuilder.Entity("API_150122.Models.Purchase", b =>
                {
                    b.Navigation("Purchase_Entries");
                });

            modelBuilder.Entity("API_150122.Models.Sale", b =>
                {
                    b.Navigation("Sale_Entries");
                });

            modelBuilder.Entity("API_150122.Models.Uom", b =>
                {
                    b.Navigation("Item_objs");
                });

            modelBuilder.Entity("API_150122.Models.Vendor", b =>
                {
                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}

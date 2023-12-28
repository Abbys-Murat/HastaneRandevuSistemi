﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proje.Data;

#nullable disable

namespace proje.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("proje.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("proje.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AdresssId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdresssId");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("proje.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingDays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Doktorlar");
                });

            modelBuilder.Entity("proje.Models.PolikinlikCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PolikinlikCategoryyId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("PolikinlikCategoryyId");

                    b.ToTable("Polikinlikler");
                });

            modelBuilder.Entity("proje.Models.AppUser", b =>
                {
                    b.HasOne("proje.Models.Address", "Adresss")
                        .WithMany()
                        .HasForeignKey("AdresssId");

                    b.Navigation("Adresss");
                });

            modelBuilder.Entity("proje.Models.Doctor", b =>
                {
                    b.HasOne("proje.Models.AppUser", null)
                        .WithMany("Doctors")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("proje.Models.PolikinlikCategory", b =>
                {
                    b.HasOne("proje.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("proje.Models.AppUser", "AppUser")
                        .WithMany("Polikinliks")
                        .HasForeignKey("AppUserId");

                    b.HasOne("proje.Models.PolikinlikCategory", "PolikinlikCategoryy")
                        .WithMany()
                        .HasForeignKey("PolikinlikCategoryyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("AppUser");

                    b.Navigation("PolikinlikCategoryy");
                });

            modelBuilder.Entity("proje.Models.AppUser", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Polikinliks");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using ES.Data.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ES.Data.Migrations
{
    [DbContext(typeof(EstateSystemDbContext))]
    [Migration("20190326075803_Estate Config")]
    partial class EstateConfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ES.Data.Identity.EstateSystemIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ES.Models.Estate", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("City")
                        .HasMaxLength(255);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnName("Country")
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedOn");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasMaxLength(1000);

                    b.Property<string>("ImageAddres")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPublic")
                        .HasColumnName("Public");

                    b.Property<bool>("IsRentable");

                    b.Property<bool>("IsSellable");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<decimal>("RentingPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("Size")
                        .HasColumnName("Size")
                        .HasColumnType("decimal");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnName("Street")
                        .HasMaxLength(255);

                    b.Property<int>("StreetAddress")
                        .HasColumnName("Street Address")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estates");

                    b.HasData(
                        new
                        {
                            Id = "ID01",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id01.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        },
                        new
                        {
                            Id = "ID02",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id02.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        },
                        new
                        {
                            Id = "ID03",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id03.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        },
                        new
                        {
                            Id = "ID04",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id04.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        },
                        new
                        {
                            Id = "ID05",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id05.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        },
                        new
                        {
                            Id = "ID06",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id06.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        },
                        new
                        {
                            Id = "ID07",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id07.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        },
                        new
                        {
                            Id = "ID08",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id08.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        },
                        new
                        {
                            Id = "ID09",
                            Capacity = 2,
                            City = "GO",
                            Country = "Bulgaria",
                            DeletedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Normal House",
                            ImageAddres = "id09.jpg",
                            IsDeleted = false,
                            IsPublic = true,
                            IsRentable = false,
                            IsSellable = false,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RentingPrice = 100m,
                            SellingPrice = 100000m,
                            Size = 2000m,
                            Street = "Who knows",
                            StreetAddress = 66
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ES.Data.Identity.EstateSystemIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ES.Data.Identity.EstateSystemIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ES.Data.Identity.EstateSystemIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ES.Data.Identity.EstateSystemIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

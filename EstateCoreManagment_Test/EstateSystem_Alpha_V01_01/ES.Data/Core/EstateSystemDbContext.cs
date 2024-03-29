﻿using System;
using System.Threading;
using System.Threading.Tasks;
using ES.Data.Config;
using ES.Data.Identity;
using ES.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ES.Data.Core
{
    public class EstateSystemDbContext : IdentityDbContext<EstateSystemIdentityUser>
    {
        public DbSet<Estate> Estates { get; set; }

        public EstateSystemDbContext(DbContextOptions<EstateSystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EstateConfig());

            builder.Entity<Estate>().HasData(SeedEstates());


            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private Estate[] SeedEstates()
        {
            return new Estate[]
            {
               new Estate()
               {
                    Id = "ID01",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id01.jpg"
               },
               new Estate()
               {
                    Id = "ID02",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id02.jpg"
               },
               new Estate()
               {
                    Id = "ID03",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id03.jpg"
               },
               new Estate()
               {
                    Id = "ID04",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id04.jpg"
               },
               new Estate()
               {
                    Id = "ID05",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id05.jpg"
               },
               new Estate()
               {
                    Id = "ID06",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id06.jpg"
               },
               new Estate()
               {
                    Id = "ID07",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id07.jpg"
               },
               new Estate()
               {
                    Id = "ID08",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id08.jpg"
               },
               new Estate()
               {
                    Id = "ID09",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = true,
                    RentingPrice = 100,
                    SellingPrice = 100000,
                    Street = "Who knows",
                    Size = 2000,
                    StreetAddress = 66,
                    IsSellable = false,
                    IsDeleted = false,
                    ImageAddres = "id09.jpg"
               }

            };
        }
    }
}
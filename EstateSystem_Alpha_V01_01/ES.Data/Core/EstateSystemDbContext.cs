using System;
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
                    IsDeleted = false
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
                    IsDeleted = false
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
                    IsDeleted = false
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
                    IsDeleted = false
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
                    IsDeleted = false
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
                    IsDeleted = false
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
                    IsDeleted = false
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
                    IsDeleted = false
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
                    IsDeleted = false
               }

            };
        }
    }
}
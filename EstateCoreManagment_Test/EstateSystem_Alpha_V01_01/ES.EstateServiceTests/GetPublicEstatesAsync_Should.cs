using ES.Data.Core;
using ES.EstateServices;
using ES.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ES.EstateServiceTests
{
    public class GetPublicEstatesAsync_Should
    {
        [Fact]
        public async Task PaginateCorrect()
        {
            var options = new DbContextOptionsBuilder<EstateSystemDbContext>()
                .UseInMemoryDatabase(databaseName: "PaginateCorrect")
                .Options;

            var estates = new Estate[]
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
               }
            };

            using (var context = new EstateSystemDbContext(options))
            {
                await context.Estates.AddRangeAsync(estates);
                await context.SaveChangesAsync();

                var estateService = new EstateService(context);
                estateService.PageSize = 3;

                var resultDTo = await estateService.GetPublicEstatesAsync(2);
                var resultEstates = resultDTo.Estates.ToArray();

                Assert.True(resultEstates.Length == 2);
                Assert.Equal("ID04", resultEstates[0].Id);
                Assert.Equal("ID05", resultEstates[1].Id);
                
            }
        }

        [Fact]
        public async Task Send_Correct_Pagination_View_Model()
        {
            var options = new DbContextOptionsBuilder<EstateSystemDbContext>()
                   .UseInMemoryDatabase(databaseName: "Can_Send_Pagination_View_Model")
                   .Options;

            var estates = new Estate[]
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
               }
            };

            using (var context = new EstateSystemDbContext(options))
            {
                await context.Estates.AddRangeAsync(estates);
                await context.SaveChangesAsync();

                var estateService = new EstateService(context);
                estateService.PageSize = 3;

                var resultDTo = await estateService.GetPublicEstatesAsync(2);

                var pageInfo = resultDTo.PagingInfo;

                Assert.Equal(2, pageInfo.CurrentPage);
                Assert.Equal(3, pageInfo.ItemsPerPage);
                Assert.Equal(5, pageInfo.TotalItems);
                Assert.Equal(2, pageInfo.TotalPages);
            }
        }

        [Fact]
        public async Task NotReturnDeletedEstates()
        {
            var options = new DbContextOptionsBuilder<EstateSystemDbContext>()
                .UseInMemoryDatabase(databaseName: "NotReturnDeletedEstates")
                .Options;

            var estates = new Estate[]
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
                    IsDeleted = true
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
                    IsDeleted = true
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
                    IsDeleted = true
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
               }
            };

            using (var context = new EstateSystemDbContext(options))
            {
                await context.Estates.AddRangeAsync(estates);
                await context.SaveChangesAsync();

                var estateService = new EstateService(context);
                estateService.PageSize = 3;

                var resultDTo = await estateService.GetPublicEstatesAsync(1);
                var resultEstates = resultDTo.Estates.ToArray();

                Assert.True(resultEstates.Length == 2);
                Assert.Equal("ID04", resultEstates[0].Id);
                Assert.Equal("ID05", resultEstates[1].Id);

            }
        }

        [Fact]
        public async Task NotReturnPrivateEstates()
        {
            var options = new DbContextOptionsBuilder<EstateSystemDbContext>()
                .UseInMemoryDatabase(databaseName: "NotReturnPrivateEstates")
                .Options;

            var estates = new Estate[]
            {
               new Estate()
               {
                    Id = "ID01",
                    Capacity =2,
                    City = "GO",
                    Country = "Bulgaria",
                    Description = "Normal House",
                    IsPublic = false,
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
                    IsPublic = false,
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
                    IsPublic = false,
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
               }
            };

            using (var context = new EstateSystemDbContext(options))
            {
                await context.Estates.AddRangeAsync(estates);
                await context.SaveChangesAsync();

                var estateService = new EstateService(context);
                estateService.PageSize = 3;

                var resultDTo = await estateService.GetPublicEstatesAsync(1);
                var resultEstates = resultDTo.Estates.ToArray();

                Assert.True(resultEstates.Length == 2);
                Assert.Equal("ID04", resultEstates[0].Id);
                Assert.Equal("ID05", resultEstates[1].Id);

            }
        }
    }
}

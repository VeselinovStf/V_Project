using ES.CustomTagHelpers.Models;
using ES.Data.Core;
using ES.EstateServices.Abstract;
using ES.EstateServices.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ES.EstateServices
{
    public class EstateService : IEstateService
    {
        private readonly EstateSystemDbContext _DbContext;
        public int PageSize = 3;

        public EstateService(EstateSystemDbContext _dbContext)
        {
            _DbContext = _dbContext ?? throw new ArgumentNullException(nameof(_dbContext));
        }

        public async Task<EstatesListDto> GetPublicEstatesAsync(int estatesPage)
        {
            var queryEstates = await this._DbContext
                    .Estates
                    .Where(e => !e.IsDeleted && e.IsPublic)
                    .OrderBy(e => e.Id)
                    .Skip((estatesPage - 1) * this.PageSize)
                    .Take(this.PageSize)
                    .ToListAsync();

            var queryEstatesCount = await this._DbContext
                .Estates
                .Where(e => !e.IsDeleted && e.IsPublic)
                .CountAsync();

            var serviceDto = new EstatesListDto()
            {
                Estates = queryEstates.Select(e => new PublicEstateDto()
                    {
                        Id = e.Id,
                        Description = e.Description
                    }),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = estatesPage,
                    ItemsPerPage = PageSize,
                    TotalItems = queryEstatesCount
                }
            };
          
            return serviceDto;
        }
    }
}

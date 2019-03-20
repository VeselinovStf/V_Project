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

        public EstateService(EstateSystemDbContext _dbContext)
        {
            _DbContext = _dbContext ?? throw new ArgumentNullException(nameof(_dbContext));
        }

        public async Task<IEnumerable<PublicEstateDto>> GetPublicEstatesAsync()
        {
            var query = await this._DbContext.Estates
                .Where(e => !e.IsDeleted && e.IsPublic)
                .ToListAsync();

            var serviceDto = query.Select(e => new PublicEstateDto()
            {
                Description = e.Description
            });

            return serviceDto;
        }
    }
}

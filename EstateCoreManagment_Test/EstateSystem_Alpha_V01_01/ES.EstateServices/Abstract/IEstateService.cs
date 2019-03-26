using ES.EstateServices.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ES.EstateServices.Abstract
{
    public interface IEstateService
    {
        Task<EstatesListDto> GetPublicEstatesAsync(int estatesPage);
    }
}

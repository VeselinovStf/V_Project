using ES.CustomTagHelpers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.EstateServices.DTOs
{
    public class EstatesListDto
    {
        public IEnumerable<PublicEstateDto> Estates { get; set; }      
        public PagingInfo PagingInfo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ES.EstateServices.DTOs
{
    public class EstatesListDto
    {
        public IEnumerable<PublicEstateDto> Estates { get; set; }
        //TODO: FIX PAGING INFO
        public PagingInfo PagingInfo { get; set; }
    }
}

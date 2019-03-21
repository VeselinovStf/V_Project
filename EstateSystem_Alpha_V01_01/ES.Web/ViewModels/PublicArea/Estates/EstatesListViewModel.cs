using ES.Web.ViewModels.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ES.Web.ViewModels.PublicArea.Estates
{
    public class EstatesListViewModel
    {
        public IEnumerable<PublicEstateViewModel> Estates { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}

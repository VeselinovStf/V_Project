using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.Abstract
{
    public interface IModifiable
    {
        DateTime? ModifiedOn { get; set; }
        DateTime? CreatedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Models.Abstract
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }

        DateTime DeletedOn { get; set; }
    }
}

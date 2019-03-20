using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Models.Abstract
{
    public interface IModifiable
    {
        DateTime ModifiedOn { get; set; }
    }
}

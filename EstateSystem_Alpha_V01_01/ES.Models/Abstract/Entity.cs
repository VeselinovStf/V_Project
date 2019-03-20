using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Models.Abstract
{
    public class Entity : IDeletable, IModifiable
    {
        public string Id { get; set; }
        public DateTime ModifiedOn { get ; set; }
        public bool IsDeleted { get ; set; }
        public DateTime DeletedOn { get ; set; }
    }
}

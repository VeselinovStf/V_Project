using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.Abstract
{
    public class Entity : IDeletable, IModifiable
    {
        public string Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}

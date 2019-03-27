using FMS.IdentityModelUser;
using FMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.UsersTypes
{
    public class EstateOwnerUser : FMSIdentityUser
    {
        public EstateOwnerUser()
        {
            this.Estates = new HashSet<Estate>();
        }

        public ICollection<Estate> Estates { get; set; }
    }
}

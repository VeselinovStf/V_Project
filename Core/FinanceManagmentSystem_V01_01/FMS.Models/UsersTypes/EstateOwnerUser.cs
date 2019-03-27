using FMS.IdentityModelUser;
using FMS.Models.Abstract;
using FMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.UsersTypes
{
    public class EstateOwnerUser : FMSIdentityUser, IUserCreationStrategy<FMSIdentityUser>
    {
        public EstateOwnerUser()
        {
            this.Estates = new HashSet<Estate>();
        }

        public ICollection<Estate> Estates { get; set; }

        public FMSIdentityUser Create(string email, string password)
        {
            return new EstateOwnerUser() { Id = Guid.NewGuid().ToString(),UserName = email, Email = email, SecurityStamp = Guid.NewGuid().ToString() };
        }
    }
}

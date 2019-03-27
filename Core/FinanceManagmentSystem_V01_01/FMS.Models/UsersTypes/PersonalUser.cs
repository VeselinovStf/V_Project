using FMS.IdentityModelUser;
using FMS.Models.Abstract;
using FMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.UsersTypes
{
    public class PersonalUser : FMSIdentityUser, IUserCreationStrategy<FMSIdentityUser>
    {
        public PersonalUser()
        {
            this.Bills = new HashSet<Bill>();
        }

        public ICollection<Bill> Bills { get; set; }

        public FMSIdentityUser Create(string email, string password)
        {
           return new PersonalUser() { Id= Guid.NewGuid().ToString(), UserName = email, Email = email, SecurityStamp = Guid.NewGuid().ToString() };
        }
    }
}

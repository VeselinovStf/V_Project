using FMS.IdentityModelUser;
using FMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.UsersTypes
{
    public class PersonalUser : FMSIdentityUser
    {
        public PersonalUser()
        {
            this.Bills = new HashSet<Bill>();
        }

        public ICollection<Bill> Bills { get; set; }
    }
}

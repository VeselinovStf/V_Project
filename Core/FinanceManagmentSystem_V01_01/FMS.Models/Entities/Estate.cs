using FMS.Models.Abstract;
using FMS.Models.UsersTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.Entities
{
    public class Estate : Entity
    {
        public string Street { get; set; }

        public string EstateOwnerUser_Id { get; set; }
        public EstateOwnerUser EstateOwnerUser { get; set; }
    }
}

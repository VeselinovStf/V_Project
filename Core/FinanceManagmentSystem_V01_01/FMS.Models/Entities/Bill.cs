using FMS.Models.Abstract;
using FMS.Models.UsersTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.Entities
{
    public class Bill : Entity
    {
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public string PersonalUser_Id { get; set; }

        public PersonalUser PersonalUSer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Models.Abstract
{
    public interface IUserCreationStrategy<T>
    {
         T Create(string email, string password);
    }
}

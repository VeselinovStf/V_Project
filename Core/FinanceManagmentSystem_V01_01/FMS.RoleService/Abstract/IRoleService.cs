using FMS.Data.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FMS.RoleService.Abstract
{
    public interface IRoleService
    {
        List<string> GetAllPublicRoles();

        Task<bool> GotRole(ClaimsPrincipal claimsPrincipal, string searchRole);

        Task AddToRole(FMSIdentityUser user, string role);
    }
}

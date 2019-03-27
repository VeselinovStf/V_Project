using FMS.BuildInRolesEnum;
using FMS.Data.Identity;
using FMS.RoleService.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FMS.RoleService
{
    public class RoleService : IRoleService
    {
        private readonly UserManager<FMSIdentityUser> userManager;

        private List<BuildInRoles> BuildInRolesSet { get;}

        public RoleService(UserManager<FMSIdentityUser> userManager)
        {
            this.BuildInRolesSet = new List<BuildInRoles>();

            BuildInRolesSet.Add(BuildInRoles.Administrator);
            BuildInRolesSet.Add(BuildInRoles.Personal);
            BuildInRolesSet.Add(BuildInRoles.EstateAgent);
            BuildInRolesSet.Add(BuildInRoles.EstateOwner);
            BuildInRolesSet.Add(BuildInRoles.FlatManagment);
            BuildInRolesSet.Add(BuildInRoles.Simple);

            this.userManager = userManager;
        }

        public List<string> GetAllPublicRoles()
        {
            List<string> Roles = new List<string>();

            foreach (var role in this.BuildInRolesSet.Skip(1))
            {
                Roles.Add(role.ToString());
            }

            return Roles;
        }

        public async Task<bool> GotRole(ClaimsPrincipal claimsPrincipal, string searchRole)
        {
            var userId = this.userManager.GetUserId(claimsPrincipal);
            var user = await this.userManager.FindByIdAsync(userId);
            var role = await this.userManager.GetRolesAsync(user);

            if (role.Contains(searchRole))
            {
                return true;
            }

            return false;
        }

        public async Task AddToRole(FMSIdentityUser user, string role)
        {
           await this.userManager.AddToRoleAsync(user, role);
        }
    }
}

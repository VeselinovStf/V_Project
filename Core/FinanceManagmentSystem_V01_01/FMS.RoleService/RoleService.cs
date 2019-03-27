using FMS.BuildInRolesEnum;
using FMS.Data.Core;
using FMS.IdentityModelUser;
using FMS.Models.Abstract;
using FMS.Models.UsersTypes;
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
        private readonly FMSDbContext dbContext;

        private static Dictionary<BuildInRoles, IUserCreationStrategy<FMSIdentityUser>> _strategies =
            new Dictionary<BuildInRoles, IUserCreationStrategy<FMSIdentityUser>>();

        private List<BuildInRoles> BuildInRolesSet { get;}

        public RoleService(UserManager<FMSIdentityUser> userManager, FMSDbContext dbContext)
        {
            this.BuildInRolesSet = new List<BuildInRoles>();

            BuildInRolesSet.Add(BuildInRoles.Administrator);
            BuildInRolesSet.Add(BuildInRoles.Personal);
            BuildInRolesSet.Add(BuildInRoles.EstateAgent);
            BuildInRolesSet.Add(BuildInRoles.EstateOwner);
            BuildInRolesSet.Add(BuildInRoles.FlatManagment);
            BuildInRolesSet.Add(BuildInRoles.Simple);

            if (!_strategies.ContainsKey(BuildInRoles.Personal))
            {
                _strategies.Add(BuildInRoles.Personal, new PersonalUser());
                // _strategies.Add(BuildInRoles.EstateAgent, new EstateAgentUser());
                _strategies.Add(BuildInRoles.EstateOwner, new EstateOwnerUser());
                //  _strategies.Add(BuildInRoles.FlatManagment, new FlatManagmentUser());
                // _strategies.Add(BuildInRoles.Simple, new SimpleUser());
            }


            this.userManager = userManager;
            this.dbContext = dbContext;
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

        public async Task<FMSIdentityUser> CreateUserInRole(string email, string password, string role)
        {
            var roleEnum = (BuildInRoles)Enum.Parse(typeof(BuildInRoles), role, true);

            var user = _strategies[roleEnum].Create(email, password);

            //var result = await userManager.CreateAsync(user, password);

            await this.userManager.AddToRoleAsync(user, role);

            if (user != null)
            {
                return user;
            }

            return null; 
        }
      
    }
}

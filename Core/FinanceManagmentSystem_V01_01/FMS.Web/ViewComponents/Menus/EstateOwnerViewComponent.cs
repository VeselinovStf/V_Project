
using FMS.IdentityModelUser;
using FMS.RoleService.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS.Web.ViewComponents.Menus
{
    public class EstateOwnerViewComponent : ViewComponent
    {
        private readonly SignInManager<FMSIdentityUser> signInManager;
        private readonly IRoleService roleService;

        public EstateOwnerViewComponent(
             SignInManager<FMSIdentityUser> signInManager,
            IRoleService roleService
            )
        {
            this.signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
            this.roleService = roleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (this.signInManager.IsSignedIn(HttpContext.User))
            {
               

                if (await roleService.GotRole(HttpContext.User, BuildInRolesEnum.BuildInRoles.EstateOwner.ToString()))
                {
                    return View("EstateOwnerMenu");
                }

                return View();
            }
            else
            {
                return View();
            }
        }
    }
}

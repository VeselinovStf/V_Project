
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
    public class SimpleAccountViewComponent : ViewComponent
    {
        private readonly SignInManager<FMSIdentityUser> signInManager;
        private readonly IRoleService roleService;

        public SimpleAccountViewComponent(
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
                
                if (await roleService.GotRole(HttpContext.User, BuildInRolesEnum.BuildInRoles.Simple.ToString()))
                {
                    return View("SimpleAccountMenu");
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

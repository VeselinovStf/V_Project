using FMS.Data.Identity;
using FMS.RoleService.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS.Web.ViewComponents.Menus
{
    public class FlatManagmentViewComponent : ViewComponent
    {
        private readonly SignInManager<FMSIdentityUser> signInManager;
        private readonly IRoleService roleService;

        public FlatManagmentViewComponent(
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
             

                if (await roleService.GotRole(HttpContext.User, BuildInRolesEnum.BuildInRoles.FlatManagment.ToString()))
                {
                    return View("FlatManagmentMenu");
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

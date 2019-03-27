using FMS.Data.Identity;
using FMS.RoleService.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Threading.Tasks;

namespace FMS.Web.ViewComponents.Menus
{
    public class PersonalMenuViewComponent : ViewComponent
    {
        private readonly SignInManager<FMSIdentityUser> signInManager;
        private readonly IRoleService roleService;

        public PersonalMenuViewComponent(
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
              

                if (await roleService.GotRole(HttpContext.User, BuildInRolesEnum.BuildInRoles.Personal.ToString()))
                {
                 

                    return View("PersonalMenu");
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
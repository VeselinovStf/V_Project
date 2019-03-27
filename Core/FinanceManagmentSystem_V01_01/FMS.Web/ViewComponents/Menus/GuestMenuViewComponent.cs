using FMS.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS.Web.ViewComponents.Menus
{
    public class GuestMenuViewComponent : ViewComponent
    {
        private readonly SignInManager<FMSIdentityUser> signInManager;

        public GuestMenuViewComponent(SignInManager<FMSIdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (!this.signInManager.IsSignedIn(HttpContext.User))
            {
                return View("GuestMenu");
            }
            else
            {
                return View();
            }
        }
    }
}

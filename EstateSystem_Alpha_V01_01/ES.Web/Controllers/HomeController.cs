using ES.EstateServices.Abstract;
using ES.Web.Models;
using ES.Web.ViewModels.PublicArea.Estates;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ES.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEstateService _EstateService;

        public HomeController(IEstateService _estateService)
        {
            _EstateService = _estateService ?? throw new System.ArgumentNullException(nameof(_estateService));
        }

        public async Task<IActionResult> Index()
        {
            var serviceModel = await this._EstateService.GetPublicEstatesAsync();

            var model = serviceModel.Select(e => new PublicEstateViewModel()
            {
                Description = e.Description
            });

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
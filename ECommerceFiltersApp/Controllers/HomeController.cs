using Microsoft.AspNetCore.Mvc;
using ECommerceFiltersApp.Filters;

namespace ECommerceFiltersApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ServiceFilter(typeof(AuthFilter))]
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult ErrorTest()
        {
            throw new Exception("Test Exception");
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
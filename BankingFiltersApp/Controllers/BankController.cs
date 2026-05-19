using Microsoft.AspNetCore.Mvc;
using BankingFiltersApp.Filters;

namespace BankingFiltersApp.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ServiceFilter(typeof(AuthenticationFilter))]
        public IActionResult Account()
        {
            return View();
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult ErrorTest()
        {
            throw new Exception("Bank Exception");
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
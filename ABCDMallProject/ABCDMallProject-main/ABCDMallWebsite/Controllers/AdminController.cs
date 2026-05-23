using Microsoft.AspNetCore.Mvc;

namespace ABCDMallWebsite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }
}

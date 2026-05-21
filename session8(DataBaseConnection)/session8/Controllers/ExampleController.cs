using Microsoft.AspNetCore.Mvc;
using session8.Models;

namespace session8.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            return View();
        }
    }
}

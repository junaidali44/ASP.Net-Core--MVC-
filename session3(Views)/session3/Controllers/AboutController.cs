using Microsoft.AspNetCore.Mvc;

namespace session3.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Session2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}

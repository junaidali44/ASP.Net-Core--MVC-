using Microsoft.AspNetCore.Mvc;

namespace session8.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProducts()
        {
            return View();
        }
    }
}

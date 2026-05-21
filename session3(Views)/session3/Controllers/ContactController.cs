using Microsoft.AspNetCore.Mvc;
using session3.Models;

namespace session3.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public IActionResult userinfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult userinfo(Contact user )
        {
            ViewBag.name = user.name;    
            ViewBag.email = user.email;    
            ViewBag.name = user.name;    
            ViewBag.subject = user.subject;
            ViewBag.message = user.messeage;
            return View();
        }
    }
}

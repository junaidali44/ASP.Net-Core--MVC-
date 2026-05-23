using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ABCDMallWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Check if user is authenticated
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.UserName = User.Identity.Name;
                ViewBag.IsAdmin = User.IsInRole("Admin");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Test page for authenticated users only
        [Authorize]
        public IActionResult MyAccount()
        {
            return Content($"Welcome {User.Identity.Name}! This page is only for logged-in users.");
        }

        // Test page for admin only
        [Authorize(Roles = "Admin")]
        public IActionResult AdminOnly()
        {
            return Content("This page is only for administrators.");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
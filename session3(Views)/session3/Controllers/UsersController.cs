using Microsoft.AspNetCore.Mvc;
using session3.Models;

namespace session3.Controllers
{
        
    public class UsersController : Controller
    {
        public IActionResult users()
        {
            var users = new UserModel
            {
                id = "",
                name = "Ahmed",
                email = "ahmed@gmail.com",
                password = "ahmed123**",
                phone = "032100555"
            };
            return View(users);
        }

    }
}

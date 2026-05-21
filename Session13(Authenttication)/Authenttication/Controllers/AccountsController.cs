using Authenttication.Models;
using Authenttication.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Authenttication.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public AccountsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterViewModel viewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new ApplicationUser { UserName = viewModel.Username, Email = viewModel.Email };
        //        var result =await this.userManager.CreateAsync(user, viewModel.Password);
        //        if (result.Succeeded)
        //        {
        //            await signInManager.SignInAsync(user, isPersistent: false);
        //            return RedirectToAction("Login");
        //        }
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //    }
        //    return View(viewModel);
        //}
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            // Fix: Remove the '!' so it runs when data IS valid
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = viewModel.Username, Email = viewModel.Email };
                var result = await this.userManager.CreateAsync(user, viewModel.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index"); // Usually redirect to Home/Index
                }

                // Optional: Add identity errors to ModelState to show them in the View
                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError("", error.Description);
                //}
            }
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(
                    user.UserName, model.Password,
                    isPersistent: false, lockoutOnFailure: false
                    );

                ViewBag.UserName = user.UserName;


                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

    }
}

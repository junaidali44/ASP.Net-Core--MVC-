using Microsoft.AspNetCore.Mvc;
using session8.Data;
using session8.ViewModel;
using session8.Models;
namespace session8.Controllers
{
    public class AddProductsController : Controller
    {
        private  ApplicationDbContext Context { get; } 
        public AddProductsController(ApplicationDbContext context) 
        {
            this.Context = context;
        }
        public IActionResult AddProducts()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProducts(AddProductsViewModel addProductsViewModel)
        {
            var products = new AddProducts {
                name = addProductsViewModel.name,
                description = addProductsViewModel.description,
                stock = addProductsViewModel.stock,
                category = addProductsViewModel.category
            };
            this.Context.Add(products);
            this.Context.SaveChanges();
            return RedirectToAction("AddProducts");
        }
    }
}

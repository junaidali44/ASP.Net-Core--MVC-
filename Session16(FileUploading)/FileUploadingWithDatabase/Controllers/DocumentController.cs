using FileUploadingWithDatabase.Data;
using FileUploadingWithDatabase.Models; // Added this
using FileUploadingWithDatabase.ViewModel; // Added this
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FileUploadingWithDatabase.Controllers
{
    public class DocumentController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IWebHostEnvironment environment;

        public DocumentController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            this.context = context;
            this.environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var documents = await context.Documents.ToListAsync();
            return View(documents);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(FileViewModel model) // Changed parameter to match View
        {
            if (ModelState.IsValid)
            {
                if (model.File != null && model.File.Length > 0)
                {
                    string uploadsFolder = Path.Combine(environment.WebRootPath, "uploads");
                    Directory.CreateDirectory(uploadsFolder);

                    string uniqueFileName = Guid.NewGuid() + Path.GetExtension(model.File.FileName);
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.File.CopyToAsync(stream);
                    }

                    // Map View Model data to your actual Database Model
                    var documentDbEntity = new DocumentModel
                    {
                        Tittle = model.Tittle,
                        Description = model.Description,
                        FileName = model.File.FileName, // Original name
                        FilePath = "/uploads/" + uniqueFileName // Saved web path
                    };

                    context.Add(documentDbEntity);
                    await context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }
    }
}

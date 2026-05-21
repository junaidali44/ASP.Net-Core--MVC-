using CRUD_Application_PracticalTest.Data;
using CRUD_Application_PracticalTest.Models;
using CRUDApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext context;
        public StudentController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var students = this.context.Student.ToList();
            return View(students);
            //return View();
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        public IActionResult EditStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                var students = new Student { StudentName = student.StudentName, StudentEmail = student.StudentEmail, DateOfBirth = student.DateOfBirth };
                this.context.Add(students);
                this.context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        
        [HttpGet] 
        public IActionResult EditStudent(int id)
        {
            var student = context.Student.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            var viewModel = new StudentViewModel
            {
                StudentId = student.StudentId,
                StudentName = student.StudentName,
                StudentEmail = student.StudentEmail,
                DateOfBirth = student.DateOfBirth
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EditStudent(StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var student = context.Student.Find(model.StudentId);
                if (student != null)
                {
                    student.StudentName = model.StudentName;
                    student.StudentEmail = model.StudentEmail;
                    student.DateOfBirth = model.DateOfBirth;

                    context.SaveChanges(); 
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = context.Student.Find(id);
            if (student != null)
            {
                context.Student.Remove(student);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCore3.Models;
using Microsoft.AspNetCore.Identity;


namespace ProjectCore3.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudRepo _studentRepo;

        private readonly SignInManager<IdentityUser> signInManager;
        public StudentController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IStudRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Details(int id)
        {
            Student student = _studentRepo.GetStudent(id);
            if (student == null)
            {
                Response.StatusCode = 404;
                return View("studentNotFound", id);
            }
            return View(id);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Student model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.rememberMe, false);
                Console.Write(result.Succeeded);
                if (result.Succeeded)
                {
                    return RedirectToAction("Details", "Student", new { id = model.Id });
                }
                ModelState.AddModelError(string.Empty, "Invalid Login");
            }
            return View(model );
        }
    }
}

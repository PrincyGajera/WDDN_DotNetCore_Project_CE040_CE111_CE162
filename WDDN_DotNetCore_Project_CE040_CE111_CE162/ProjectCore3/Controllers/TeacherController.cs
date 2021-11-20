using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCore3.Models;

using Microsoft.AspNetCore.Identity;

namespace ProjectCore3.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeachRepo _teachRepo;

        private readonly SignInManager<IdentityUser> signInManager;
        public TeacherController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ITeachRepo teachRepo)
        {
            _teachRepo = teachRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Details(int id)
        {
            Teacher teacher = _teachRepo.GetTeacher(id);
            if (teacher == null)
            {
                Response.StatusCode = 404;
                return View("studentNotFound", id);
            }
            return View(teacher);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Teacher teacher = _teachRepo.GetTeacher(id);
            return View(teacher);
        }
        [HttpPost]
        public IActionResult Edit(Student model)
        {
            if (ModelState.IsValid)
            {
                Student student = _teachRepo.Update(model);
                student.OS = model.OS;
                student.MFP = model.MFP;
                student.AA = model.AA;
                student.WDDN = model.WDDN;
                student.AT = model.AT;
                Student updatedStudent = _teachRepo.Update(student);
                return RedirectToAction("index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Teacher model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.rememberMe, false);
                if (result.Succeeded)
                {
                    
                    return RedirectToAction("index", "Question");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login");
            }
            return View(model);
        }
    }
}

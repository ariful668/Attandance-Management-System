using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using StudentManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly NewAttendanceContext _Context;

        public UsersController(NewAttendanceContext context)
        {
            _Context = context;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (HttpContext.Session.Get("userName") != null)
            {
                return View();
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public IActionResult Login(Users model)
        {
            var user = _Context.Users.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
            if (!ModelState.IsValid && user != null)
            {
                string username = user.FirstName + user.LastName;
                //HttpContext.Session.SetString("userName", "username");
                HttpContext.Session.Get("userName");

                if (user.UserType.Equals("Admin"))
                {

                    return RedirectToAction("AdminIndex", "Users", new { userName = username });
                }
                else if (user.UserType.Equals("Teacher"))
                {
                    return RedirectToAction("TeacherIndex", "Users", new { userName = username });
                }
                else if (user.UserType.Equals("Student"))
                {
                    return RedirectToAction("StudentIndex", "Users", new { userName = username });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                
            }
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userName");
            return RedirectToAction("Login", "Login");

        }


        public IActionResult AdminIndex()
        {
            return View();
        }

        public IActionResult StudentIndex()
        {
            return View();
        }

        public IActionResult TeacherIndex()
        {
            return View();
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
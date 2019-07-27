using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("About/About");
        }

        public IActionResult Contact()
        {
            return View("Contact/Contact");
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult LoginPage()
        {
            return View("Login/LoginPage");
        }
        public IActionResult Notice()
        {
            return View("Notice/Notice");
        }
        public IActionResult Event()
        {
            return View("Event/Event");
        }
        public IActionResult Gallery()
        {
            return View("Gallery/Gallery");
        }
        public IActionResult AdminProfile()
        {
            return View("AdminBackend/AdminProfile");
        }
        public IActionResult TeacherProfile()
        {
            return View("TeacherBackend/TeacherProfile");
        }
        public IActionResult StudentProfile()
        {
            return View("StudentBackend/StudentProfile");
        }
        public IActionResult TeacherViewClass()
        {
            return View("TeacherBackend/TeacherViewClass");
        }
        public IActionResult TeacherAttendancePage()
        {
            return View("TeacherBackend/TeacherAttendancePage");
        }
        public IActionResult TeacherAttendanceList()
        {
            return View("TeacherBackend/TeacherAttendanceList");
        }
        public IActionResult TeacherViewStudent()
        {
            return View("TeacherBackend/TeacherViewStudent");
        }
        public IActionResult LoginAttendance()
        {
            return View("Attendance/LoginAttendance");
        }
        public IActionResult TakeAttendance()
        {
            return View("Attendance/TakeAttendance");
        }
        public IActionResult AttendanceStatus()
        {
            return View("Attendance/AttendanceStatus");
        }
        public IActionResult Registration()
        {
            return View("AdminBackend/Registration");
        }
        public IActionResult Admission()
        {
            return View("AdminBackend/Admission");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

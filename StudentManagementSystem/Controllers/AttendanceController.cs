using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using static StudentManagementSystem.Models.GiveAttendanceVM;

namespace StudentManagementSystem.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly NewAttendanceContext _context;


        public AttendanceController(NewAttendanceContext context)
        {
            _context = context;
        }
        /*
        public IActionResult GiveAttendance()
        {
            var join= (from a in _context.Attends

                      join c in _context.Classes
                      on a.StudentId equals c.StudentId

                      join se in _context.Sections
                      on c.StudentId equals se.StudentId

                      join su in _context.Subjects
                      on se.StudentId equals su.StudentId

                      join st in _context.Students
                      on su.StudentId equals st.StudentId

                      join t in _context.Teachers
                      on st.StudentId equals t.StudentId

                      select new GiveAttendanceVM
                      {
                          StudentId= st.StudentId,
                          StudentName = st.StudentName,
                          Date = a.Date,
                          Status = a.Status ,
                          RoomNumber = a.RoomNumber ,
                          ClassName = c.ClassName,
                          SectionName = se.SectionName,
                          SubjectName = su.SubjectName ,
                          TeacherName = t.TeacherName
                      }).ToList();
            return View(join);
        }
        */
        /*
        public IActionResult GiveAttendance()
        {
            GiveAttendanceVM vm = new GiveAttendanceVM();
            var Attends = _context.Attends.ToList();
            var Classes = _context.Classes.ToList();
            var Sections = _context.Sections.ToList();
            var Subjects = _context.Subjects.ToList();
            var Students = _context.Students.ToList();
            var Teachers = _context.Teachers.ToList();

            vm.Attends = _context.Attends.ToList();
            vm.Classes = _context.Classes.ToList();
            vm.Sections = _context.Sections.ToList();
            vm.Subjects = _context.Subjects.ToList();
            vm.Students = _context.Students.ToList();
            vm.Teachers = _context.Teachers.ToList();
            return View(vm);
        }
        */
        /*
        public IActionResult GiveAttendance()
        {
            var a = _context.GiveAttendanceVM.ToList();
            GiveAttendanceVMList b = new GiveAttendanceVMList
            {
                GiveAttendanceVMAll = a

            };
            return View(b);
        }
        public IActionResult Okay()
        {
            var q = _context.Classes.ToList();
            ClassesList w = new ClassesList
            {
                ClassesAll = q

            };
            return View(w);
        }
        */
    }
}




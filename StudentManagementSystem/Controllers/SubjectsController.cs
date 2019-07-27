using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly NewAttendanceContext _context;

        public SubjectsController(NewAttendanceContext context)
        {
            _context = context;
        }

        // GET: Subjects
        public async Task<IActionResult> Index()
        {
            var newAttendanceContext = _context.Subjects.Include(s => s.Subject);
            return View(await newAttendanceContext.ToListAsync());
        }

        // GET: Subjects/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subjects = await _context.Subjects
                .Include(s => s.Subject)
                .FirstOrDefaultAsync(m => m.SubjectId == id);
            if (subjects == null)
            {
                return NotFound();
            }

            return View(subjects);
        }

        // GET: Subjects/Create
        public IActionResult Create()
        {
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "SubjectId", "SubjectName");
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubjectId,SubjectName")] Subjects subjects)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subjects);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "SubjectId", "SubjectName", subjects.SubjectId);
            return View(subjects);
        }

        // GET: Subjects/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subjects = await _context.Subjects.FindAsync(id);
            if (subjects == null)
            {
                return NotFound();
            }
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "SubjectId", "SubjectName", subjects.SubjectId);
            return View(subjects);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("SubjectId,SubjectName")] Subjects subjects)
        {
            if (id != subjects.SubjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subjects);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectsExists(subjects.SubjectId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubjectId"] = new SelectList(_context.Subjects, "SubjectId", "SubjectName", subjects.SubjectId);
            return View(subjects);
        }

        // GET: Subjects/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subjects = await _context.Subjects
                .Include(s => s.Subject)
                .FirstOrDefaultAsync(m => m.SubjectId == id);
            if (subjects == null)
            {
                return NotFound();
            }

            return View(subjects);
        }

        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var subjects = await _context.Subjects.FindAsync(id);
            _context.Subjects.Remove(subjects);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubjectsExists(long id)
        {
            return _context.Subjects.Any(e => e.SubjectId == id);
        }
    }
}

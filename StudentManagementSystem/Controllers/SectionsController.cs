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
    public class SectionsController : Controller
    {
        private readonly NewAttendanceContext _context;

        public SectionsController(NewAttendanceContext context)
        {
            _context = context;
        }

        // GET: Sections
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sections.ToListAsync());
        }

        // GET: Sections/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sections = await _context.Sections
                .FirstOrDefaultAsync(m => m.SectionId == id);
            if (sections == null)
            {
                return NotFound();
            }

            return View(sections);
        }

        // GET: Sections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SectionId,SectionName")] Sections sections)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sections);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sections);
        }

        // GET: Sections/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sections = await _context.Sections.FindAsync(id);
            if (sections == null)
            {
                return NotFound();
            }
            return View(sections);
        }

        // POST: Sections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("SectionId,SectionName")] Sections sections)
        {
            if (id != sections.SectionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sections);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionsExists(sections.SectionId))
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
            return View(sections);
        }

        // GET: Sections/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sections = await _context.Sections
                .FirstOrDefaultAsync(m => m.SectionId == id);
            if (sections == null)
            {
                return NotFound();
            }

            return View(sections);
        }

        // POST: Sections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var sections = await _context.Sections.FindAsync(id);
            _context.Sections.Remove(sections);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionsExists(long id)
        {
            return _context.Sections.Any(e => e.SectionId == id);
        }
    }
}

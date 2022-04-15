using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assingment_solution_1.Models;

namespace Assingment_solution_1.Controllers
{
    public class CustCategoriesController : Controller
    {
        private readonly dbContext _context;

        public CustCategoriesController(dbContext context)
        {
            _context = context;
        }

        // GET: CustCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustCategory.ToListAsync());
        }

        // GET: CustCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custCategory = await _context.CustCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custCategory == null)
            {
                return NotFound();
            }

            return View(custCategory);
        }

        // GET: CustCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] CustCategory custCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(custCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(custCategory);
        }

        // GET: CustCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custCategory = await _context.CustCategory.FindAsync(id);
            if (custCategory == null)
            {
                return NotFound();
            }
            return View(custCategory);
        }

        // POST: CustCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] CustCategory custCategory)
        {
            if (id != custCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(custCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustCategoryExists(custCategory.Id))
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
            return View(custCategory);
        }

        // GET: CustCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custCategory = await _context.CustCategory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (custCategory == null)
            {
                return NotFound();
            }

            return View(custCategory);
        }

        // POST: CustCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var custCategory = await _context.CustCategory.FindAsync(id);
            _context.CustCategory.Remove(custCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustCategoryExists(int id)
        {
            return _context.CustCategory.Any(e => e.Id == id);
        }
    }
}

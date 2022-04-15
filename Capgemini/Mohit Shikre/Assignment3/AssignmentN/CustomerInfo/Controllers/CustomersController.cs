using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerInfo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CustomerInfo.Controllers
{
    public class CustomersController : Controller
    {
        private AssignmentContext _context;

        public CustomersController(AssignmentContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var assignmentContext = _context.Customer.Include(c => c.CategoryNavigation);
            return View(await assignmentContext.ToListAsync());
        }
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.CategoryNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
        public IActionResult Add()
        {
            ViewData["Category"] = new SelectList(_context.CustCategory, "Id", "CatName");
            return View();
        }
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Id,FirstName,LastName,Dob,Mobile,Email,Category")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Category"] = new SelectList(_context.CustCategory, "Id", "CatName", customer.Category);
            return View(customer);
        }
        public async Task<IActionResult>Modify(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["Category"] = new SelectList(_context.CustCategory, "Id", "CatName", customer.Category);
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Modify(byte id, [Bind("Id,FirstName,LastName,Dob,Mobile,Email,Category")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            ViewData["Category"] = new SelectList(_context.CustCategory, "Id", "CatName", customer.Category);
            return View(customer);
        }
        public async Task<IActionResult> Remove(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.CategoryNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Remove")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveConfirmed(byte id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool CustomerExists(byte id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}

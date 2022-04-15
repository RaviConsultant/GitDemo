using Customers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Controllers
{
    public class CustCategoryController : Controller
    {
        private readonly CustomersContext _context;

        public CustCategoryController(CustomersContext context)
        {
            _context = context;
        }

        // GET: CustCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustCategory.ToListAsync());
        }

        // GET: CustCategories/Details
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CatName")] CustCategory custCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(custCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(custCategory);
        }

        // GET: CustCategories/Edit
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

        // POST: CustCategories/Edit

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CatName")] CustCategory custCategory)
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

        // GET: CustCategories/Delete
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
        // POST: CustCategories-Delete
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

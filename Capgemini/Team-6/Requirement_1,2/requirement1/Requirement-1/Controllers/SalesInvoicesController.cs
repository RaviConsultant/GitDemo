using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Requirement_1.Models;

namespace Requirement_1.Controllers
{
    public class SalesInvoicesController : Controller
    {
        private readonly AppDbContext _context;

        public SalesInvoicesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SalesInvoices
        public async Task<IActionResult> Index()
        {
            return View(await _context.SalesInvoice.ToListAsync());
        }

        // GET: SalesInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesInvoice = await _context.SalesInvoice
                .FirstOrDefaultAsync(m => m.InvoiceNumber == id);
            if (salesInvoice == null)
            {
                return NotFound();
            }

            return View(salesInvoice);
        }

        // GET: SalesInvoices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesInvoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InvoiceNumber,InvoiceDate,CustomerID,ProductID,Quantity,Rate")] SalesInvoice salesInvoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesInvoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesInvoice);
        }

        // GET: SalesInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesInvoice = await _context.SalesInvoice.FindAsync(id);
            if (salesInvoice == null)
            {
                return NotFound();
            }
            return View(salesInvoice);
        }

        // POST: SalesInvoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InvoiceNumber,InvoiceDate,CustomerID,ProductID,Quantity,Rate")] SalesInvoice salesInvoice)
        {
            if (id != salesInvoice.InvoiceNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesInvoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesInvoiceExists(salesInvoice.InvoiceNumber))
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
            return View(salesInvoice);
        }

        // GET: SalesInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesInvoice = await _context.SalesInvoice
                .FirstOrDefaultAsync(m => m.InvoiceNumber == id);
            if (salesInvoice == null)
            {
                return NotFound();
            }

            return View(salesInvoice);
        }

        // POST: SalesInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesInvoice = await _context.SalesInvoice.FindAsync(id);
            _context.SalesInvoice.Remove(salesInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesInvoiceExists(int id)
        {
            return _context.SalesInvoice.Any(e => e.InvoiceNumber == id);
        }
    }
}

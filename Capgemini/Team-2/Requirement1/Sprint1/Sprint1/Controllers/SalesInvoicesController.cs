using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sprint1.Models;

namespace Sprint1.Controllers
{
    public class SalesInvoicesController : Controller
    {
        private readonly DigitalTradersContext _context;

        public SalesInvoicesController(DigitalTradersContext context)
        {
            _context = context;
        }

        // GET: SalesInvoices
        public async Task<IActionResult> Index()
        {
            var digitalTradersContext = _context.SalesInvoice.Include(s => s.CustomerID).Include(s => s.Product);
            return View(await digitalTradersContext.ToListAsync());
        }

        // GET: SalesInvoices/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesInvoice = await _context.SalesInvoice
                .Include(s => s.CustomerID)
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesInvoice == null)
            {
                return NotFound();
            }

            return View(salesInvoice);
        }

        // GET: SalesInvoices/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductTitle");
            return View();
        }

        // POST: SalesInvoices/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InvoiceDate,CustomerId,ProductId,Quantity,Rate")] SalesInvoice salesInvoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesInvoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", salesInvoice.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductTitle", salesInvoice.ProductId);
            return View(salesInvoice);
        }

        // GET: SalesInvoices/Edit
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", salesInvoice.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductTitle", salesInvoice.ProductId);
            return View(salesInvoice);
        }

        // POST: SalesInvoices/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InvoiceDate,CustomerId,ProductId,Quantity,Rate")] SalesInvoice salesInvoice)
        {
            if (id != salesInvoice.Id)
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
                    if (!SalesInvoiceExists(salesInvoice.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", salesInvoice.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "ProductTitle", salesInvoice.ProductId);
            return View(salesInvoice);
        }

        // GET: SalesInvoices/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesInvoice = await _context.SalesInvoice
                .Include(s => s.CustomerID)
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesInvoice == null)
            {
                return NotFound();
            }

            return View(salesInvoice);
        }

        // POST: SalesInvoices/Delete
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
            return _context.SalesInvoice.Any(e => e.Id == id);
        }
    }
}

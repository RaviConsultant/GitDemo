using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigiTrade.Invoicing.Models;

namespace DigiTrade.Invoicing.Controllers
{
    public class SaleInvoicesController : Controller
    {
        private readonly DigiTradeDbContext _context;

        public SaleInvoicesController(DigiTradeDbContext context)
        {
            _context = context;
        }

        // GET: SaleInvoices
        public async Task<IActionResult> Index()
        {
            var digiTradeDbContext = _context.SaleInvoices.Include(s => s.Customer).Include(s => s.Product);
            return View(await digiTradeDbContext.ToListAsync());
        }

        // GET: SaleInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleInvoice = await _context.SaleInvoices
                .Include(s => s.Customer)
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.InvoiceNumber == id);
            if (saleInvoice == null)
            {
                return NotFound();
            }

            return View(saleInvoice);
        }

        // GET: SaleInvoices/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName");
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Title");
            return View();
        }

        // POST: SaleInvoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InvoiceNumber,InvoiceDate,CustomerId,ProductId,Qty,Rate")] SaleInvoice saleInvoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saleInvoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", saleInvoice.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Title", saleInvoice.ProductId);
            return View(saleInvoice);
        }

        // GET: SaleInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleInvoice = await _context.SaleInvoices.FindAsync(id);
            if (saleInvoice == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", saleInvoice.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Title", saleInvoice.ProductId);
            return View(saleInvoice);
        }

        // POST: SaleInvoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InvoiceNumber,InvoiceDate,CustomerId,ProductId,Qty,Rate")] SaleInvoice saleInvoice)
        {
            if (id != saleInvoice.InvoiceNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saleInvoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaleInvoiceExists(saleInvoice.InvoiceNumber))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CustomerName", saleInvoice.CustomerId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "Title", saleInvoice.ProductId);
            return View(saleInvoice);
        }

        // GET: SaleInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var saleInvoice = await _context.SaleInvoices
                .Include(s => s.Customer)
                .Include(s => s.Product)
                .FirstOrDefaultAsync(m => m.InvoiceNumber == id);
            if (saleInvoice == null)
            {
                return NotFound();
            }


            return View(saleInvoice);
        }

        // POST: SaleInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saleInvoice = await _context.SaleInvoices.FindAsync(id);
            _context.SaleInvoices.Remove(saleInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaleInvoiceExists(int id)
        {
            return _context.SaleInvoices.Any(e => e.InvoiceNumber == id);
        }
    }
}

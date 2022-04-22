using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigiTradeASP.NETWEBAPP.Models;
using DigiTradeMVC.NET.Models;

namespace DigiTradeMVC.NET.Controllers
{
    public class SalesInvoiceController : Controller
    {
        private readonly AppDbContext _context;

        public SalesInvoiceController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SalesInvoice
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.SaleInvoices.Include(s => s.CustName).Include(s => s.ProdName);
            return View(await appDbContext.ToListAsync());
        }

        // GET: SalesInvoice/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesInvoice = await _context.SaleInvoices
                .Include(s => s.CustName)
                .Include(s => s.ProdName)
                .FirstOrDefaultAsync(m => m.InvoiceNo == id);
            if (salesInvoice == null)
            {
                return NotFound();
            }

            return View(salesInvoice);
        }

        // GET: SalesInvoice/Create
        public IActionResult Create()
        {
            ViewData["Cust_Id"] = new SelectList(_context.Customers, "Cust_Id", "CustName");
            ViewData["Prod_Id"] = new SelectList(_context.Products, "Prod_Id", "ProdName");
            return View();
        }

        // POST: SalesInvoice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InvoiceNo,Invoicedate,Cust_Id,Prod_Id,Qty,Rate")] SalesInvoice salesInvoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesInvoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cust_Id"] = new SelectList(_context.Customers, "Cust_Id", "CustName", salesInvoice.Cust_Id);
            ViewData["Prod_Id"] = new SelectList(_context.Products, "Prod_Id", "ProdName", salesInvoice.Prod_Id);
            return View(salesInvoice);
        }

        // GET: SalesInvoice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesInvoice = await _context.SaleInvoices.FindAsync(id);
            if (salesInvoice == null)
            {
                return NotFound();
            }
            ViewData["Cust_Id"] = new SelectList(_context.Customers, "Cust_Id", "CustName", salesInvoice.Cust_Id);
            ViewData["Prod_Id"] = new SelectList(_context.Products, "Prod_Id", "ProdName", salesInvoice.Prod_Id);
            return View(salesInvoice);
        }

        // POST: SalesInvoice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InvoiceNo,Invoicedate,Cust_Id,Prod_Id,Qty,Rate")] SalesInvoice salesInvoice)
        {
            if (id != salesInvoice.InvoiceNo)
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
                    if (!SalesInvoiceExists(salesInvoice.InvoiceNo))
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
            ViewData["Cust_Id"] = new SelectList(_context.Customers, "Cust_Id", "CustName", salesInvoice.Cust_Id);
            ViewData["Prod_Id"] = new SelectList(_context.Products, "Prod_Id", "ProdName", salesInvoice.Prod_Id);
            return View(salesInvoice);
        }

        // GET: SalesInvoice/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesInvoice = await _context.SaleInvoices
                .Include(s => s.CustName)
                .Include(s => s.ProdName)
                .FirstOrDefaultAsync(m => m.InvoiceNo == id);
            if (salesInvoice == null)
            {
                return NotFound();
            }

            return View(salesInvoice);
        }

        // POST: SalesInvoice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesInvoice = await _context.SaleInvoices.FindAsync(id);
            _context.SaleInvoices.Remove(salesInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesInvoiceExists(int id)
        {
            return _context.SaleInvoices.Any(e => e.InvoiceNo == id);
        }
    }
}

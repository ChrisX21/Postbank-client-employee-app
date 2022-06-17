using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PostbankApp.Data;
using PostbankApp.Models;

namespace PostbankApp.Controllers
{
    public class SalersController : Controller
    {
        private readonly DWHDbContext _context;

        public SalersController(DWHDbContext context)
        {
            _context = context;
        }

        // GET: Salers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Saler.ToListAsync());
        }

        // GET: Salers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saler = await _context.Saler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saler == null)
            {
                return NotFound();
            }

            return View(saler);
        }

        // GET: Salers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Salers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username")] Saler saler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saler);
        }

        // GET: Salers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saler = await _context.Saler.FindAsync(id);
            if (saler == null)
            {
                return NotFound();
            }
            return View(saler);
        }

        // POST: Salers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username")] Saler saler)
        {
            if (id != saler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalerExists(saler.Id))
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
            return View(saler);
        }

        // GET: Salers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saler = await _context.Saler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saler == null)
            {
                return NotFound();
            }

            return View(saler);
        }

        // POST: Salers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saler = await _context.Saler.FindAsync(id);
            _context.Saler.Remove(saler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalerExists(int id)
        {
            return _context.Saler.Any(e => e.Id == id);
        }
    }
}

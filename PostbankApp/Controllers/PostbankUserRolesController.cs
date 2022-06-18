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
    public class PostbankUserRolesController : Controller
    {
        private readonly AppDBContext _context;

        public PostbankUserRolesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: PostbankUserRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.PostbankUserRole.ToListAsync());
        }

        // GET: PostbankUserRoles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postbankUserRole = await _context.PostbankUserRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postbankUserRole == null)
            {
                return NotFound();
            }

            return View(postbankUserRole);
        }

        // GET: PostbankUserRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PostbankUserRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,NormalizedName,ConcurrencyStamp")] PostbankUserRole postbankUserRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postbankUserRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(postbankUserRole);
        }

        // GET: PostbankUserRoles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postbankUserRole = await _context.PostbankUserRole.FindAsync(id);
            if (postbankUserRole == null)
            {
                return NotFound();
            }
            return View(postbankUserRole);
        }

        // POST: PostbankUserRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,NormalizedName,ConcurrencyStamp")] PostbankUserRole postbankUserRole)
        {
            if (id != postbankUserRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postbankUserRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostbankUserRoleExists(postbankUserRole.Id))
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
            return View(postbankUserRole);
        }

        // GET: PostbankUserRoles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postbankUserRole = await _context.PostbankUserRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postbankUserRole == null)
            {
                return NotFound();
            }

            return View(postbankUserRole);
        }

        // POST: PostbankUserRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var postbankUserRole = await _context.PostbankUserRole.FindAsync(id);
            _context.PostbankUserRole.Remove(postbankUserRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostbankUserRoleExists(string id)
        {
            return _context.PostbankUserRole.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperSuper.Models;

namespace SuperSuper.Controllers
{
    public class SuperUsersController : Controller
    {
        private readonly SuperSuperContext _context;

        public SuperUsersController(SuperSuperContext context)
        {
            _context = context;
        }

        // GET: SuperUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.SuperUser.ToListAsync());
        }

        // GET: SuperUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superUser = await _context.SuperUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (superUser == null)
            {
                return NotFound();
            }

            return View(superUser);
        }

        // GET: SuperUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SuperUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,Address,EmailAdress,Password")] SuperUser superUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(superUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(superUser);
        }

        // GET: SuperUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superUser = await _context.SuperUser.FindAsync(id);
            if (superUser == null)
            {
                return NotFound();
            }
            return View(superUser);
        }

        // POST: SuperUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,Address,EmailAdress,Password")] SuperUser superUser)
        {
            if (id != superUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(superUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuperUserExists(superUser.Id))
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
            return View(superUser);
        }

        // GET: SuperUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var superUser = await _context.SuperUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (superUser == null)
            {
                return NotFound();
            }

            return View(superUser);
        }

        // POST: SuperUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var superUser = await _context.SuperUser.FindAsync(id);
            _context.SuperUser.Remove(superUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuperUserExists(int id)
        {
            return _context.SuperUser.Any(e => e.Id == id);
        }
    }
}

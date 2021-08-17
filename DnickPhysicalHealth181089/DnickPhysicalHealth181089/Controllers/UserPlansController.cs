using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DnickPhysicalHealth181089.Data;
using DnickPhysicalHealth181089.Models;
using Microsoft.AspNetCore.Authorization;

namespace DnickPhysicalHealth181089.Controllers
{
    public class UserPlansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserPlansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserPlans
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.UserPlan.Include(u => u.User);
            return View(await applicationDbContext.ToListAsync());
        }
        [Authorize]
        public async Task<IActionResult> ChoosePlan()
        {
            var applicationDbContext = _context.UserPlan.Include(u => u.User);
            return View(await applicationDbContext.ToListAsync());
        }
        [Authorize]

        // GET: UserPlans/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPlan = await _context.UserPlan
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userPlan == null)
            {
                return NotFound();
            }

            return View(userPlan);
        }

        // GET: UserPlans/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: UserPlans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("UserId,Birthday,Height,Weight,Id")] UserPlan userPlan)
        {
            if (ModelState.IsValid)
            {
                userPlan.Id = Guid.NewGuid();
                _context.Add(userPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userPlan.UserId);
            return View(userPlan);
        }

        // GET: UserPlans/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPlan = await _context.UserPlan.FindAsync(id);
            if (userPlan == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userPlan.UserId);
            return View(userPlan);
        }

        // POST: UserPlans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(Guid id, [Bind("UserId,Birthday,Height,Weight,Id")] UserPlan userPlan)
        {
            if (id != userPlan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserPlanExists(userPlan.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", userPlan.UserId);
            return View(userPlan);
        }
        [Authorize]
        // GET: UserPlans/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPlan = await _context.UserPlan
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userPlan == null)
            {
                return NotFound();
            }

            return View(userPlan);
        }

        // POST: UserPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var userPlan = await _context.UserPlan.FindAsync(id);
            _context.UserPlan.Remove(userPlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserPlanExists(Guid id)
        {
            return _context.UserPlan.Any(e => e.Id == id);
        }

   



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gym.Models;

namespace Gym.Controllers
{
    public class GymMembersController : Controller
    {
        private readonly GymContext _context;

        public GymMembersController(GymContext context)
        {
            _context = context;
        }

        // GET: GymMembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Members.ToListAsync());
        }

        // GET: GymMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymMember = await _context.Members
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (gymMember == null)
            {
                return NotFound();
            }

            return View(gymMember);
        }

        // GET: GymMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GymMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,LastName,FirstName,Membership_End_Date,Planned_exercise_id,Address,PhoneNumber")] GymMember gymMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gymMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gymMember);
        }

        // GET: GymMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymMember = await _context.Members.FindAsync(id);
            if (gymMember == null)
            {
                return NotFound();
            }
            return View(gymMember);
        }

        // POST: GymMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonID,LastName,FirstName,Membership_End_Date,Planned_exercise_id,Address,PhoneNumber")] GymMember gymMember)
        {
            if (id != gymMember.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gymMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GymMemberExists(gymMember.PersonID))
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
            return View(gymMember);
        }

        // GET: GymMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymMember = await _context.Members
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (gymMember == null)
            {
                return NotFound();
            }

            return View(gymMember);
        }

        // POST: GymMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gymMember = await _context.Members.FindAsync(id);
            _context.Members.Remove(gymMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GymMemberExists(int id)
        {
            return _context.Members.Any(e => e.PersonID == id);
        }
    }
}

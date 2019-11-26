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
    public class PlannedWorkoutController : Controller
    {
        private readonly GymContext _context;

        public PlannedWorkoutController(GymContext context)
        {
            _context = context;
        }

        // GET: PlannedWorkout
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlannedWorkouts.ToListAsync());
        }

        // GET: PlannedWorkout/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plannedWorkout = await _context.PlannedWorkouts
                .FirstOrDefaultAsync(m => m.ExerciseID == id);
            if (plannedWorkout == null)
            {
                return NotFound();
            }

            return View(plannedWorkout);
        }

        // GET: PlannedWorkout/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlannedWorkout/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExerciseID,Exercise_Name,Planned_Set_Number,Planned_Reps,Planned_Weight")] PlannedWorkout plannedWorkout)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plannedWorkout);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plannedWorkout);
        }

        // GET: PlannedWorkout/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plannedWorkout = await _context.PlannedWorkouts.FindAsync(id);
            if (plannedWorkout == null)
            {
                return NotFound();
            }
            return View(plannedWorkout);
        }

        // POST: PlannedWorkout/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExerciseID,Exercise_Name,Planned_Set_Number,Planned_Reps,Planned_Weight")] PlannedWorkout plannedWorkout)
        {
            if (id != plannedWorkout.ExerciseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plannedWorkout);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlannedWorkoutExists(plannedWorkout.ExerciseID))
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
            return View(plannedWorkout);
        }

        // GET: PlannedWorkout/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plannedWorkout = await _context.PlannedWorkouts
                .FirstOrDefaultAsync(m => m.ExerciseID == id);
            if (plannedWorkout == null)
            {
                return NotFound();
            }

            return View(plannedWorkout);
        }

        // POST: PlannedWorkout/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plannedWorkout = await _context.PlannedWorkouts.FindAsync(id);
            _context.PlannedWorkouts.Remove(plannedWorkout);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlannedWorkoutExists(int id)
        {
            return _context.PlannedWorkouts.Any(e => e.ExerciseID == id);
        }
    }
}

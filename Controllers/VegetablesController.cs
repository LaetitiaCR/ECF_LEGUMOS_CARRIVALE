using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ECF_LEGUMOS_CARRIVALE.Data;
using ECF_LEGUMOS_CARRIVALE.Models;

namespace ECF_LEGUMOS_CARRIVALE.Controllers
{
    public class VegetablesController : Controller
    {
        private readonly LegumosContext _context;

        public VegetablesController(LegumosContext context)
        {
            _context = context;
        }

        // GET: Vegetables
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vegetables.ToListAsync());
        }

        // GET: Vegetables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetables
                .FirstOrDefaultAsync(m => m.VegetableId == id);
            if (vegetable == null)
            {
                return NotFound();
            }

            return View(vegetable);
        }

        // GET: Vegetables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vegetables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VegetableId,Name,Variety,PrimaryColor,LifeTime,Fresh")] Vegetable vegetable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vegetable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vegetable);
        }

        // GET: Vegetables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetables.FindAsync(id);
            if (vegetable == null)
            {
                return NotFound();
            }
            return View(vegetable);
        }

        // POST: Vegetables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VegetableId,Name,Variety,PrimaryColor,LifeTime,Fresh")] Vegetable vegetable)
        {
            if (id != vegetable.VegetableId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vegetable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VegetableExists(vegetable.VegetableId))
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
            return View(vegetable);
        }

        // GET: Vegetables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vegetable = await _context.Vegetables
                .FirstOrDefaultAsync(m => m.VegetableId == id);
            if (vegetable == null)
            {
                return NotFound();
            }

            return View(vegetable);
        }

        // POST: Vegetables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vegetable = await _context.Vegetables.FindAsync(id);
            _context.Vegetables.Remove(vegetable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VegetableExists(int id)
        {
            return _context.Vegetables.Any(e => e.VegetableId == id);
        }
    }
}

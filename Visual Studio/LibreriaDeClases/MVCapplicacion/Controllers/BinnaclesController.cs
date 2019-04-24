using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCapplicacion.Models;

namespace MVCapplicacion.Controllers
{
    public class BinnaclesController : Controller
    {
        private readonly MVCapplicacionContext _context;
        
        public BinnaclesController(MVCapplicacionContext context)
        {
            _context = context;
        }

        [HttpPost]
        public string Index(string searchString, bool NotUsed)
        {
            return $"[HttpPost] with {searchString}";
        }

        // GET: Binnacles
        public async Task<IActionResult> Index(string searchString)
        {
            IQueryable<int> IdsQuery = from b in _context.Binnacle
                                          orderby b.PublishDate descending 
                                          select b.Id;

            var binnacle = from m in _context.Binnacle
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                binnacle.Where(s => s.Body.Contains(searchString));
            }
            /*
             An unhandled exception occurred while processing the request.
            NullReferenceException: Object reference not set to an instance of an object.
            MVCapplicacion.Controllers.BinnaclesController.Index(string searchString) in BinnaclesController.cs, line 42
             */
            /*
            var BinnacleVM = new BinnacleViewModel
            {
                BinnaclesIds = new SelectList(await IdsQuery.Distinct().ToListAsync()),
                BinnaclesTypes = { "tarea", "investigar", "otro"},
                Binnacles = await binnacle.ToListAsync()
            };
            */

            var BinnacleVM = new BinnacleViewModel();

            BinnacleVM.BinnaclesIds = new SelectList(await IdsQuery.Distinct().ToListAsync());
            BinnacleVM.BinnaclesTypes = new List<string> { "tarea", "investigar", "otro" };
            BinnacleVM.Binnacles = await binnacle.ToListAsync();

            return View(BinnacleVM);
        }

        // GET: Binnacles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binnacle = await _context.Binnacle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (binnacle == null)
            {
                return NotFound();
            }

            return View(binnacle);
        }

        // GET: Binnacles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Binnacles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Body,PublishDate", "BinnacleType")] Binnacle binnacle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(binnacle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(binnacle);
        }

        // GET: Binnacles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binnacle = await _context.Binnacle.FindAsync(id);
            if (binnacle == null)
            {
                return NotFound();
            }
            return View(binnacle);
        }

        // POST: Binnacles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Body,PublishDate", "BinnacleType")] Binnacle binnacle)
        {
            if (id != binnacle.Id)
            {
                return NotFound();
            }

            // see https://docs.microsoft.com/es-es/aspnet/core/tutorials/first-mvc-app/controller-methods-views?view=aspnetcore-2.2#processing-the-post-request
            // The ModelState.IsValid method verifies that the data submitted in the form can be used to modify 
            // (edit or update) a Binnacle object. If the data is valid, it's saved
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(binnacle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BinnacleExists(binnacle.Id))
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
            return View(binnacle);
        }

        // GET: Binnacles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binnacle = await _context.Binnacle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (binnacle == null)
            {
                return NotFound();
            }

            return View(binnacle);
        }

        // POST: Binnacles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var binnacle = await _context.Binnacle.FindAsync(id);
            _context.Binnacle.Remove(binnacle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BinnacleExists(int id)
        {
            return _context.Binnacle.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Back_Projet_RPG.Data;
using Back_Projet_RPG.Models;
using Back_Projet_RPG.Repositories;

namespace Back_Projet_RPG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnemiesController : ControllerBase
    {
        private readonly IRepository<Enemy> _enemyRepository;

        public EnemiesController(IRepository<Enemy> repository)
        {
            _enemyRepository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Enemy> enemies = await _enemyRepository.GetAll();

            return Ok(enemies);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var enemy = await _enemyRepository.GetById(id);

            if (enemy == null)
                return NotFound(new
                {
                    Message = "There is no Enemy with this Id."
                });
            
            return Ok(enemy);
        }

        #region crée par le logiciel automatiquement
        //// GET: Enemys
        //public async Task<IActionResult> Index()
        //{
        //      return _context.Enemys != null ? 
        //                  View(await _context.Enemys.ToListAsync()) :
        //                  Problem("Entity set 'ApplicationDbContext.Enemys'  is null.");
        //}

        //// GET: Enemys/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Enemys == null)
        //    {
        //        return NotFound();
        //    }

        //    var enemy = await _context.Enemys
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (enemy == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(enemy);
        //}

        //// GET: Enemys/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Enemys/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,LifePoint,Strength,Stamina,Agility,Intellect,Luck")] Enemy enemy)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(enemy);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(enemy);
        //}

        //// GET: Enemys/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Enemys == null)
        //    {
        //        return NotFound();
        //    }

        //    var enemy = await _context.Enemys.FindAsync(id);
        //    if (enemy == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(enemy);
        //}

        //// POST: Enemys/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,LifePoint,Strength,Stamina,Agility,Intellect,Luck")] Enemy enemy)
        //{
        //    if (id != enemy.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(enemy);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!EnemyExists(enemy.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(enemy);
        //}

        //// GET: Enemys/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Enemys == null)
        //    {
        //        return NotFound();
        //    }

        //    var enemy = await _context.Enemys
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (enemy == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(enemy);
        //}

        //// POST: Enemys/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Enemys == null)
        //    {
        //        return Problem("Entity set 'ApplicationDbContext.Enemys'  is null.");
        //    }
        //    var enemy = await _context.Enemys.FindAsync(id);
        //    if (enemy != null)
        //    {
        //        _context.Enemys.Remove(enemy);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EnemyExists(int id)
        //{
        //  return (_context.Enemys?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
        #endregion
    }
}

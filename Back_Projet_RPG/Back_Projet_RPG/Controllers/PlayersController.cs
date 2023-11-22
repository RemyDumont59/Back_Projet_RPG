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
    public class PlayersController : ControllerBase
    {
        private readonly IRepository<Player> _playerRepository;

        public PlayersController(IRepository<Player> repository)
        {
            _playerRepository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Player> players = await _playerRepository.GetAll();

            return Ok(players);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var player = await _playerRepository.GetById(id);

            if (player == null)
                return NotFound(new
                {
                    Message = "There is no Player with this Id."
                });
            
            return Ok(player);
        }

        #region crée par le logiciel automatiquement
        //// GET: Players
        //public async Task<IActionResult> Index()
        //{
        //      return _context.Players != null ? 
        //                  View(await _context.Players.ToListAsync()) :
        //                  Problem("Entity set 'ApplicationDbContext.Players'  is null.");
        //}

        //// GET: Players/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Players == null)
        //    {
        //        return NotFound();
        //    }

        //    var player = await _context.Players
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (player == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(player);
        //}

        //// GET: Players/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Players/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,LifePoint,Strength,Stamina,Agility,Intellect,Luck")] Player player)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(player);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(player);
        //}

        //// GET: Players/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Players == null)
        //    {
        //        return NotFound();
        //    }

        //    var player = await _context.Players.FindAsync(id);
        //    if (player == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(player);
        //}

        //// POST: Players/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,LifePoint,Strength,Stamina,Agility,Intellect,Luck")] Player player)
        //{
        //    if (id != player.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(player);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PlayerExists(player.Id))
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
        //    return View(player);
        //}

        //// GET: Players/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Players == null)
        //    {
        //        return NotFound();
        //    }

        //    var player = await _context.Players
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (player == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(player);
        //}

        //// POST: Players/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Players == null)
        //    {
        //        return Problem("Entity set 'ApplicationDbContext.Players'  is null.");
        //    }
        //    var player = await _context.Players.FindAsync(id);
        //    if (player != null)
        //    {
        //        _context.Players.Remove(player);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PlayerExists(int id)
        //{
        //  return (_context.Players?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
        #endregion
    }
}

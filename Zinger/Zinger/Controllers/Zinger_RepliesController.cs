using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Zinger.Data;
using Zinger.Models;

namespace Zinger.Controllers
{
    public class Zinger_RepliesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Zinger_RepliesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Zinger_Replies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zinger_Replies.ToListAsync());
        }

        // GET: Zinger_Replies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zinger_Replies = await _context.Zinger_Replies
                .FirstOrDefaultAsync(m => m.Replying_Zinger_ID == id);
            if (zinger_Replies == null)
            {
                return NotFound();
            }

            return View(zinger_Replies);
        }

        // GET: Zinger_Replies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zinger_Replies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Replying_Zinger_ID,Replying_U_ID,Zinger_Reply_Content,Date_Time_Stamp")] Zinger_Replies zinger_Replies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zinger_Replies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zinger_Replies);
        }

        // GET: Zinger_Replies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zinger_Replies = await _context.Zinger_Replies.FindAsync(id);
            if (zinger_Replies == null)
            {
                return NotFound();
            }
            return View(zinger_Replies);
        }

        // POST: Zinger_Replies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Replying_Zinger_ID,Replying_U_ID,Zinger_Reply_Content,Date_Time_Stamp")] Zinger_Replies zinger_Replies)
        {
            if (id != zinger_Replies.Replying_Zinger_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zinger_Replies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Zinger_RepliesExists(zinger_Replies.Replying_Zinger_ID))
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
            return View(zinger_Replies);
        }

        // GET: Zinger_Replies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zinger_Replies = await _context.Zinger_Replies
                .FirstOrDefaultAsync(m => m.Replying_Zinger_ID == id);
            if (zinger_Replies == null)
            {
                return NotFound();
            }

            return View(zinger_Replies);
        }

        // POST: Zinger_Replies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zinger_Replies = await _context.Zinger_Replies.FindAsync(id);
            _context.Zinger_Replies.Remove(zinger_Replies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Zinger_RepliesExists(int id)
        {
            return _context.Zinger_Replies.Any(e => e.Replying_Zinger_ID == id);
        }
    }
}

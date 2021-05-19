using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Zinger.Models;

namespace Zinger.Controllers
{
    [Authorize]
    public class ZingersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<AdminController> logger;

        public ZingersController(ApplicationDbContext context, 
                               RoleManager<IdentityRole> roleManager,
                               UserManager<ApplicationUser> userManager,
                               ILogger<AdminController> logger)
        {
            _context = context;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.logger = logger;
        }

        // GET: Zingers
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zingers.ToListAsync());
        }

        // GET: Zingers/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zingers = await _context.Zingers
                .FirstOrDefaultAsync(m => m.Zinger_ID == id);
            if (zingers == null)
            {
                return NotFound();
            }

            return View(zingers);
        }

        // GET: Zingers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zingers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Zinger_ID, ApplicationUserId, Replying_Zinger_ID, Hashtag,Zinger_Content,Date_Time_Stamp")] Zingers zingers, string userId)
        {

            if (ModelState.IsValid)
            {
                _context.Add(zingers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zingers);
        }

        // GET: Zingers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zingers = await _context.Zingers.FindAsync(id);
            if (zingers == null)
            {
                return NotFound();
            }
            return View(zingers);
        }

        // POST: Zingers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Zinger_ID,Hashtag,Zinger_Content,Date_Time_Stamp")] Zingers zingers)
        {
            if (id != zingers.Zinger_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zingers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZingersExists(zingers.Zinger_ID))
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
            return View(zingers);
        }

        // GET: Zingers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zingers = await _context.Zingers
                .FirstOrDefaultAsync(m => m.Zinger_ID == id);
            if (zingers == null)
            {
                return NotFound();
            }

            return View(zingers);
        }

        // POST: Zingers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zingers = await _context.Zingers.FindAsync(id);
            _context.Zingers.Remove(zingers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZingersExists(int id)
        {
            return _context.Zingers.Any(e => e.Zinger_ID == id);
        }
    }
}

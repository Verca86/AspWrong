using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspWrong.Data;
using AspWrong.Models;

namespace AspWrong.Controllers
{
    public class Article2Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Article2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Article2
        public async Task<IActionResult> Index()
        {
              return _context.Article2 != null ? 
                          View(await _context.Article2.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Article2'  is null.");
        }
        // Get Search
        public async Task<IActionResult> Vyhledat(string searchString)
        {
            if (_context.Article2 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Article2'  is null.");
            }

            var article2 = from m in _context.Article2
                           select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                article2 = article2.Where(x => x.Jméno!.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                article2 = article2.Where(s => s.Příjmení!.Contains(searchString));
            }

            return View(await article2.ToListAsync());
        }
        // GET: Article2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Article2 == null)
            {
                return NotFound();
            }

            var article2 = await _context.Article2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article2 == null)
            {
                return NotFound();
            }

            return View(article2);
        }

        // GET: Article2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Article2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Jméno,Příjmení,Popis")] Article2 article2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(article2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article2);
        }

        // GET: Article2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Article2 == null)
            {
                return NotFound();
            }

            var article2 = await _context.Article2.FindAsync(id);
            if (article2 == null)
            {
                return NotFound();
            }
            return View(article2);
        }

        // POST: Article2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Jméno,Příjmení,popis")] Article2 article2)
        {
            if (id != article2.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Article2Exists(article2.Id))
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
            return View(article2);
        }

        // GET: Article2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Article2 == null)
            {
                return NotFound();
            }

            var article2 = await _context.Article2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article2 == null)
            {
                return NotFound();
            }

            return View(article2);
        }

        // POST: Article2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Article2 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Article2'  is null.");
            }
            var article2 = await _context.Article2.FindAsync(id);
            if (article2 != null)
            {
                _context.Article2.Remove(article2);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Article2Exists(int id)
        {
          return (_context.Article2?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

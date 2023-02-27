﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspBlog.Data;
using AspBlog.Models;

namespace AspBlog.Controllers
{
    public class Article1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Article1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Article1
        public async Task<IActionResult> Index()
        {
              return _context.Article1 != null ? 
                          View(await _context.Article1.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Article1'  is null.");
        }

        // GET: Article1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Article1 == null)
            {
                return NotFound();
            }

            var article1 = await _context.Article1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article1 == null)
            {
                return NotFound();
            }

            return View(article1);
        }

        // GET: Article1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Article1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Jméno,Příjmení,Adresa,Obec,PsČ,Telefon,Email")] Article1 article1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(article1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article1);
        }

        // GET: Article1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Article1 == null)
            {
                return NotFound();
            }

            var article1 = await _context.Article1.FindAsync(id);
            if (article1 == null)
            {
                return NotFound();
            }
            return View(article1);
        }

        // POST: Article1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Jméno,Příjmení,Adresa,Obec,PSČ,Telefon,Email")] Article1 article1)
        {
            if (id != article1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Article1Exists(article1.Id))
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
            return View(article1);
        }

        // GET: Article1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Article1 == null)
            {
                return NotFound();
            }

            var article1 = await _context.Article1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article1 == null)
            {
                return NotFound();
            }

            return View(article1);
        }

        // POST: Article1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Article1 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Article1'  is null.");
            }
            var article1 = await _context.Article1.FindAsync(id);
            if (article1 != null)
            {
                _context.Article1.Remove(article1);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Article1Exists(int id)
        {
          return (_context.Article1?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

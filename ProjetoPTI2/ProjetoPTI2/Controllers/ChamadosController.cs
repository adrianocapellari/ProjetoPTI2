﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoPTI2.Data;
using ProjetoPTI2.Models;

namespace ProjetoPTI2.Controllers
{
    public class ChamadosController : Controller
    {
        private readonly ProjetoPTI2Context _context;

        public ChamadosController(ProjetoPTI2Context context)
        {
            _context = context;
        }

        // GET: Chamados
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chamado.ToListAsync());
        }

        // GET: Chamados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamado = await _context.Chamado
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chamado == null)
            {
                return NotFound();
            }

            return View(chamado);
        }

        // GET: Chamados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chamados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Descricao,Dt_abertura,Dt_fechamento,Resolucao,Resolvedor,Solicitante")] Chamado chamado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chamado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chamado);
        }

        // GET: Chamados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamado = await _context.Chamado.FindAsync(id);
            if (chamado == null)
            {
                return NotFound();
            }
            return View(chamado);
        }

        // POST: Chamados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Descricao,Dt_abertura,Dt_fechamento,Resolucao,Resolvedor,Solicitante")] Chamado chamado)
        {
            if (id != chamado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chamado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChamadoExists(chamado.Id))
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
            return View(chamado);
        }

        // GET: Chamados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamado = await _context.Chamado
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chamado == null)
            {
                return NotFound();
            }

            return View(chamado);
        }

        // POST: Chamados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chamado = await _context.Chamado.FindAsync(id);
            _context.Chamado.Remove(chamado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChamadoExists(int id)
        {
            return _context.Chamado.Any(e => e.Id == id);
        }
    }
}

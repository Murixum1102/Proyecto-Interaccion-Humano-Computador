using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ihc.Data;
using Ihc.Models;

namespace Ihc.Controllers
{
    public class SolicitudVacacionesController : Controller
    {
        private readonly IntranetContext _context;

        public SolicitudVacacionesController(IntranetContext context)
        {
            _context = context;
        }

        // GET: SolicitudVacaciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.SolicitudVacaciones.ToListAsync());
        }

        // GET: SolicitudVacaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudVacaciones = await _context.SolicitudVacaciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudVacaciones == null)
            {
                return NotFound();
            }

            return View(solicitudVacaciones);
        }

        // GET: SolicitudVacaciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SolicitudVacaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreSolicitante,ApellidoSolicitante,NumeroEmpleado,FechaInicio,FechaFin")] SolicitudVacaciones solicitudVacaciones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitudVacaciones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitudVacaciones);
        }

        // GET: SolicitudVacaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudVacaciones = await _context.SolicitudVacaciones.FindAsync(id);
            if (solicitudVacaciones == null)
            {
                return NotFound();
            }
            return View(solicitudVacaciones);
        }

        // POST: SolicitudVacaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreSolicitante,ApellidoSolicitante,NumeroEmpleado,FechaInicio,FechaFin")] SolicitudVacaciones solicitudVacaciones)
        {
            if (id != solicitudVacaciones.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitudVacaciones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudVacacionesExists(solicitudVacaciones.Id))
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
            return View(solicitudVacaciones);
        }

        // GET: SolicitudVacaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudVacaciones = await _context.SolicitudVacaciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudVacaciones == null)
            {
                return NotFound();
            }

            return View(solicitudVacaciones);
        }

        // POST: SolicitudVacaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitudVacaciones = await _context.SolicitudVacaciones.FindAsync(id);
            _context.SolicitudVacaciones.Remove(solicitudVacaciones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudVacacionesExists(int id)
        {
            return _context.SolicitudVacaciones.Any(e => e.Id == id);
        }
    }
}

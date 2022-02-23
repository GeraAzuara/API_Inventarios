using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventariosAPI.Data;
using InventariosAPI.ModelsFull;

namespace InventariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CveUnidad_CPController : ControllerBase
    {
        private readonly FullDBContext _context;

        public CveUnidad_CPController(FullDBContext context)
        {
            _context = context;
        }

        #region Métodos consumidos en produccion
        // GET: api/CveUnidad_CP
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cveunidad>>> GetCveunidad()
        {
            return await _context.Cveunidad.ToListAsync();
        }

        // GET: api/CveUnidad_CP/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cveunidad>> GetCveunidad(string id)
        {
            var cveunidad = await _context.Cveunidad.FindAsync(id);

            if (cveunidad == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return cveunidad;
        }
        #endregion

        #region Funcionalidad inutilizada en produccion
        // PUT: api/CveUnidad_CP/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCveunidad(string id, Cveunidad cveunidad)
        {
            if (id != cveunidad.ClaveUnidadId)
            {
                return BadRequest();
            }

            _context.Entry(cveunidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CveunidadExists(id))
                {
                    return NotFound("Registro(s) no encontado(s).");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CveUnidad_CP
        [HttpPost]
        public async Task<ActionResult<Cveunidad>> PostCveunidad(Cveunidad cveunidad)
        {
            _context.Cveunidad.Add(cveunidad);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CveunidadExists(cveunidad.ClaveUnidadId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCveunidad", new { id = cveunidad.ClaveUnidadId }, cveunidad);
        }

        // DELETE: api/CveUnidad_CP/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cveunidad>> DeleteCveunidad(string id)
        {
            var cveunidad = await _context.Cveunidad.FindAsync(id);
            if (cveunidad == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.Cveunidad.Remove(cveunidad);
            await _context.SaveChangesAsync();

            return cveunidad;
        }

        private bool CveunidadExists(string id)
        {
            return _context.Cveunidad.Any(e => e.ClaveUnidadId == id);
        }
        #endregion
    }
}

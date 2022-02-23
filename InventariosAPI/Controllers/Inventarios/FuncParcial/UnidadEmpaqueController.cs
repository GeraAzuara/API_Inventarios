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
    public class UnidadEmpaqueController : ControllerBase
    {
        private readonly FullDBContext _context;

        public UnidadEmpaqueController(FullDBContext context)
        {
            _context = context;
        }

        #region Métodos consumidos en produccion
        // GET: api/UnidadEmpaque
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InUnidadEmpaque>>> GetInUnidadEmpaque()
        {
            return await _context.InUnidadEmpaque.ToListAsync();
        }

        // GET: api/UnidadEmpaque/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InUnidadEmpaque>> GetInUnidadEmpaque(short id)
        {
            var inUnidadEmpaque = await _context.InUnidadEmpaque.FindAsync(id);

            if (inUnidadEmpaque == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return inUnidadEmpaque;
        }
        #endregion

        #region Funcionalidad inutilizada en produccion
        // PUT: api/UnidadEmpaque/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInUnidadEmpaque(short id, InUnidadEmpaque inUnidadEmpaque)
        {
            if (id != inUnidadEmpaque.UnidadEmpaqueId)
            {
                return BadRequest();
            }

            _context.Entry(inUnidadEmpaque).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InUnidadEmpaqueExists(id))
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

        // POST: api/UnidadEmpaque
        [HttpPost]
        public async Task<ActionResult<InUnidadEmpaque>> PostInUnidadEmpaque(InUnidadEmpaque inUnidadEmpaque)
        {
            _context.InUnidadEmpaque.Add(inUnidadEmpaque);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInUnidadEmpaque", new { id = inUnidadEmpaque.UnidadEmpaqueId }, inUnidadEmpaque);
        }

        // DELETE: api/UnidadEmpaque/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InUnidadEmpaque>> DeleteInUnidadEmpaque(short id)
        {
            var inUnidadEmpaque = await _context.InUnidadEmpaque.FindAsync(id);
            if (inUnidadEmpaque == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.InUnidadEmpaque.Remove(inUnidadEmpaque);
            await _context.SaveChangesAsync();

            return inUnidadEmpaque;
        }

        private bool InUnidadEmpaqueExists(short id)
        {
            return _context.InUnidadEmpaque.Any(e => e.UnidadEmpaqueId == id);
        }
        #endregion
    }
}

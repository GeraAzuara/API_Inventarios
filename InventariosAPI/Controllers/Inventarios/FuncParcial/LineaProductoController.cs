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
    public class LineaProductoController : ControllerBase
    {
        private readonly FullDBContext _context;

        public LineaProductoController(FullDBContext context)
        {
            _context = context;
        }

        #region Métodos consumidos en produccion
        // GET: api/LineaProducto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InLineaproducto>>> GetInLineaproducto()
        {
            return await _context.InLineaproducto.ToListAsync();
        }

        // GET: api/LineaProducto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InLineaproducto>> GetInLineaproducto(int id)
        {
            var inLineaproducto = await _context.InLineaproducto.FindAsync(id);

            if (inLineaproducto == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return inLineaproducto;
        }
        #endregion

        #region Funcionalidad inutilizada en produccion
        // PUT: api/LineaProducto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInLineaproducto(int id, InLineaproducto inLineaproducto)
        {
            if (id != inLineaproducto.LineaProductoId)
            {
                return BadRequest();
            }

            _context.Entry(inLineaproducto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InLineaproductoExists(id))
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

        // POST: api/LineaProducto
        [HttpPost]
        public async Task<ActionResult<InLineaproducto>> PostInLineaproducto(InLineaproducto inLineaproducto)
        {
            _context.InLineaproducto.Add(inLineaproducto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInLineaproducto", new { id = inLineaproducto.LineaProductoId }, inLineaproducto);
        }

        // DELETE: api/LineaProducto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InLineaproducto>> DeleteInLineaproducto(int id)
        {
            var inLineaproducto = await _context.InLineaproducto.FindAsync(id);
            if (inLineaproducto == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.InLineaproducto.Remove(inLineaproducto);
            await _context.SaveChangesAsync();

            return inLineaproducto;
        }

        private bool InLineaproductoExists(int id)
        {
            return _context.InLineaproducto.Any(e => e.LineaProductoId == id);
        }
        #endregion
    }
}

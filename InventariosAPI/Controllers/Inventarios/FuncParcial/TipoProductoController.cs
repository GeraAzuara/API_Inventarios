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
    public class TipoProductoController : ControllerBase
    {
        private readonly FullDBContext _context;
        public TipoProductoController(FullDBContext context)
        {
            _context = context;
        }

        #region Métodos consumidos en produccion
        // GET: api/TipoProducto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InTipoproducto>>> GetInTipoproducto()
        {
            return await _context.InTipoproducto.ToListAsync();
        }

        // GET: api/TipoProducto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InTipoproducto>> GetInTipoproducto(int id)
        {
            var inTipoproducto = await _context.InTipoproducto.FindAsync(id);

            if (inTipoproducto == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return inTipoproducto;
        }
        #endregion

        #region Funcionalidad inutilizada en producción
        // PUT: api/TipoProducto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInTipoproducto(int id, InTipoproducto inTipoproducto)
        {
            if (id != inTipoproducto.InTipoProductoId)
            {
                return BadRequest();
            }

            _context.Entry(inTipoproducto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InTipoproductoExists(id))
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

        // POST: api/TipoProducto
        [HttpPost]
        public async Task<ActionResult<InTipoproducto>> PostInTipoproducto(InTipoproducto inTipoproducto)
        {
            _context.InTipoproducto.Add(inTipoproducto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInTipoproducto", new { id = inTipoproducto.InTipoProductoId }, inTipoproducto);
        }

        // DELETE: api/TipoProducto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InTipoproducto>> DeleteInTipoproducto(int id)
        {
            var inTipoproducto = await _context.InTipoproducto.FindAsync(id);
            if (inTipoproducto == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.InTipoproducto.Remove(inTipoproducto);
            await _context.SaveChangesAsync();

            return inTipoproducto;
        }

        private bool InTipoproductoExists(int id)
        {
            return _context.InTipoproducto.Any(e => e.InTipoProductoId == id);
        }

        #endregion
    }
}

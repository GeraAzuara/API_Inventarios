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
    public class MarcaController : ControllerBase
    {
        private readonly FullDBContext _context;

        public MarcaController(FullDBContext context)
        {
            _context = context;
        }

        #region Métodos consumidos en produccion
        // GET: api/Marca
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InMarca>>> GetInMarca()
        {
            return await _context.InMarca.ToListAsync();
        }

        // GET: api/Marca/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InMarca>> GetInMarca(int id)
        {
            var inMarca = await _context.InMarca.FindAsync(id);

            if (inMarca == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return inMarca;
        }
        #endregion

        #region Funcionalidad inutilizada en produccion
        // PUT: api/Marca/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInMarca(int id, InMarca inMarca)
        {
            if (id != inMarca.InMarcaId)
            {
                return BadRequest();
            }

            _context.Entry(inMarca).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InMarcaExists(id))
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

        // POST: api/Marca
        [HttpPost]
        public async Task<ActionResult<InMarca>> PostInMarca(InMarca inMarca)
        {
            _context.InMarca.Add(inMarca);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInMarca", new { id = inMarca.InMarcaId }, inMarca);
        }

        // DELETE: api/Marca/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InMarca>> DeleteInMarca(int id)
        {
            var inMarca = await _context.InMarca.FindAsync(id);
            if (inMarca == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.InMarca.Remove(inMarca);
            await _context.SaveChangesAsync();

            return inMarca;
        }

        private bool InMarcaExists(int id)
        {
            return _context.InMarca.Any(e => e.InMarcaId == id);
        }
        #endregion       
    }
}

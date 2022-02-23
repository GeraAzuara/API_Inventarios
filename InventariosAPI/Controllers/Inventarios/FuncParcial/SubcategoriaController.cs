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
    public class SubcategoriaController : ControllerBase
    {
        private readonly FullDBContext _context;

        public SubcategoriaController(FullDBContext context)
        {
            _context = context;
        }

        #region Métodos consumidos en produccion
        // GET: api/Subcategoria
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InSubcategoria>>> GetInSubcategoria()
        {
            return await _context.InSubcategoria.ToListAsync();
        }

        // GET: api/Subcategoria/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InSubcategoria>> GetInSubcategoria(int id)
        {
            var inSubcategoria = await _context.InSubcategoria.FindAsync(id);

            if (inSubcategoria == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return inSubcategoria;
        }
        #endregion

        #region Funcionalidad inutilizada en produccion
        // PUT: api/Subcategoria/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInSubcategoria(int id, InSubcategoria inSubcategoria)
        {
            if (id != inSubcategoria.InSubCategoriaId)
            {
                return BadRequest();
            }

            _context.Entry(inSubcategoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InSubcategoriaExists(id))
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

        // POST: api/Subcategoria
        [HttpPost]
        public async Task<ActionResult<InSubcategoria>> PostInSubcategoria(InSubcategoria inSubcategoria)
        {
            _context.InSubcategoria.Add(inSubcategoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInSubcategoria", new { id = inSubcategoria.InSubCategoriaId }, inSubcategoria);
        }

        // DELETE: api/Subcategoria/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InSubcategoria>> DeleteInSubcategoria(int id)
        {
            var inSubcategoria = await _context.InSubcategoria.FindAsync(id);
            if (inSubcategoria == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.InSubcategoria.Remove(inSubcategoria);
            await _context.SaveChangesAsync();

            return inSubcategoria;
        }

        private bool InSubcategoriaExists(int id)
        {
            return _context.InSubcategoria.Any(e => e.InSubCategoriaId == id);
        }
        #endregion
    }
}

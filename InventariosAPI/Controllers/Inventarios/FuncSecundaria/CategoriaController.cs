using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventariosAPI.Data;
using InventariosAPI.ModelsFull;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace InventariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CategoriaController : ControllerBase
    {
        private readonly FullDBContext _context;

        public CategoriaController(FullDBContext context)
        {
            _context = context;
        }

        #region Métodos consumidos en produccion
        // GET: api/Categoria
        [HttpGet]
        public IEnumerable<InCategoria> GetInCategoria()
        {
            return _context.InCategoria;
        }

        // GET: api/Categoria/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInCategoria([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inCategoria = await _context.InCategoria.FindAsync(id);

            if (inCategoria == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return Ok(inCategoria);
        }
        #endregion

        #region Funcionalidad inutilizada en produccion
        // PUT: api/Categoria/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInCategoria([FromRoute] int id, [FromBody] InCategoria inCategoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inCategoria.InCategoriaId)
            {
                return BadRequest();
            }

            _context.Entry(inCategoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InCategoriaExists(id))
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

        // POST: api/Categoria
        [HttpPost]
        public async Task<IActionResult> PostInCategoria([FromBody] InCategoria inCategoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InCategoria.Add(inCategoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInCategoria", new { id = inCategoria.InCategoriaId }, inCategoria);
        }

        // DELETE: api/Categoria/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInCategoria([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inCategoria = await _context.InCategoria.FindAsync(id);
            if (inCategoria == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.InCategoria.Remove(inCategoria);
            await _context.SaveChangesAsync();

            return Ok(inCategoria);
        }

        private bool InCategoriaExists(int id)
        {
            return _context.InCategoria.Any(e => e.InCategoriaId == id);
        }
        #endregion
    }
}
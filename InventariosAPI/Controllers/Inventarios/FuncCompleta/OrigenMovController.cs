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
    public class OrigenMovController : ControllerBase
    {
        private readonly FullDBContext _context;

        public OrigenMovController(FullDBContext context)
        {
            _context = context;
        }

        // GET: api/OrigenMov
        [HttpGet]
        public IEnumerable<Origenmov> GetOrigenmov()
        {
            return _context.Origenmov;
        }

        // GET: api/OrigenMov/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrigenmov([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var origenmov = await _context.Origenmov.FindAsync(id);

            if (origenmov == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return Ok(origenmov);
        }

        // PUT: api/OrigenMov/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrigenmov([FromRoute] int id, [FromBody] Origenmov origenmov)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != origenmov.OrigenMovId)
            {
                return BadRequest();
            }

            _context.Entry(origenmov).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrigenmovExists(id))
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

        // POST: api/OrigenMov
        [HttpPost]
        public async Task<IActionResult> PostOrigenmov([FromBody] Origenmov origenmov)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Origenmov.Add(origenmov);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrigenmovExists(origenmov.OrigenMovId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrigenmov", new { id = origenmov.OrigenMovId }, origenmov);
        }

        // DELETE: api/OrigenMov/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrigenmov([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var origenmov = await _context.Origenmov.FindAsync(id);
            if (origenmov == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.Origenmov.Remove(origenmov);
            await _context.SaveChangesAsync();

            return Ok(origenmov);
        }

        private bool OrigenmovExists(int id)
        {
            return _context.Origenmov.Any(e => e.OrigenMovId == id);
        }
    }
}
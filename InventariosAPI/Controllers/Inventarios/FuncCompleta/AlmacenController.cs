using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventariosAPI.Data;
using InventariosAPI.ModelsFull;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using InventariosAPI.Data.Utils;
using Microsoft.AspNetCore.Http;

namespace InventariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AlmacenController : ControllerBase
    {
        private readonly FullDBContext _context;

        public AlmacenController(FullDBContext context)
        {
            _context = context;
        }

        // GET: api/Almacen
        [HttpGet]
        public IEnumerable<Almacenes> GetAlmacen()
        {
            return _context.Almacenes;
        }

        // GET: api/Almacen/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlmacen([FromRoute] short id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Almacen = await _context.Almacenes.FindAsync(id);

            if (Almacen == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }
            return Ok(Almacen);
        }

        // PUT: api/Almacen/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlmacen([FromRoute] short id, [FromBody] Almacenes Almacen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Almacen.AlmacenId)
            {
                return BadRequest();
            }

            _context.Entry(Almacen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlmacenExists(id))
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

        // POST: api/Almacen
        [HttpPost]
        public async Task<IActionResult> PostAlmacen([FromBody] Almacenes Almacen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Almacenes.Add(Almacen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlmacen", new { id = Almacen.AlmacenId }, Almacen);
        }

        // DELETE: api/Almacen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlmacen([FromRoute] short id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Almacen = await _context.Almacenes.FindAsync(id);
            if (Almacen == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.Almacenes.Remove(Almacen);
            await _context.SaveChangesAsync();

            return Ok(Almacen);
        }

        private bool AlmacenExists(short id)
        {
            return _context.Almacenes.Any(e => e.AlmacenId == id);
        }
    }
}
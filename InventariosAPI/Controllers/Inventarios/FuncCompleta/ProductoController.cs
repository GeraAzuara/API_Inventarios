using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventariosAPI.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using InventariosAPI.ModelsFull;

namespace InventariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductoController : ControllerBase
    {
        private readonly FullDBContext _context;

        public ProductoController(FullDBContext context)
        {
            _context = context;
        }

        // GET: api/Producto
        [HttpGet]
        public IEnumerable<InProducto> GetInProducto()
        {
            var data = _context.InProducto.ToList();
            return data;
        }

        // GET: api/Producto/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInProducto([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inProducto = await _context.InProducto.FindAsync(id);

            if (inProducto == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return Ok(inProducto);
        }

        // PUT: api/Producto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInProducto([FromRoute] string id, [FromBody] InProducto inProducto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inProducto.InProductoId)
            {
                return BadRequest();
            }

            _context.Entry(inProducto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InProductoExists(id))
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

        // POST: api/Producto
        [HttpPost]
        public async Task<IActionResult> PostInProducto([FromBody] InProducto inProducto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InProducto.Add(inProducto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InProductoExists(inProducto.InProductoId))
                {
                    return new ConflictObjectResult(inProducto);
                    //return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInProducto", new { id = inProducto.InProductoId }, inProducto);
        }

        // DELETE: api/Producto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInProducto([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inProducto = await _context.InProducto.FindAsync(id);
            if (inProducto == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.InProducto.Remove(inProducto);
            await _context.SaveChangesAsync();

            return Ok(inProducto);
        }

        private bool InProductoExists(string id)
        {
            return _context.InProducto.Any(e => e.InProductoId == id);
        }
    }
}
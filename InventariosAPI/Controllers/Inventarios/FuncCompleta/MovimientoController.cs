using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventariosAPI.Data;
using InventariosAPI.Data.Utils;
using InventariosAPI.ModelsFull;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Security.Claims;

namespace InventariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MovimientoController : ControllerBase
    {
        private readonly FullDBContext _context;

        public MovimientoController(FullDBContext context)
        {
            _context = context;
        }

        // GET: api/Movimiento
        [HttpGet]
        public IEnumerable<InMovimientos> GetInMovimientos()
        {
            return _context.InMovimientos;
        }

        //  GET: api/Movimiento/FilteredByKyes
        [HttpGet("Filtered")]
        [ActionName("Filtered")]
        public IEnumerable<InMovimientos> GetInMovimientosFiltered(Filtro_Mov Filtros)
        {
            List<int> Filtros_Llaves = new List<int>();
            List<short> Filtros_Almacenes = new List<short>();
            List<int> Filtros_OMovs = new List<int>();
            List<string> Filtros_Productos = new List<string>();

            //  Aplicacion de filtros por llave(s)
            if (Filtros.F_Llave.Count() > 0)                
                Filtros_Llaves = Filtros.F_Llave.Select(f => f.Valor).ToList();

            //  Aplicacion de filtros por Almacen(es)
            if (Filtros.F_Almacenes.Count() > 0)
                Filtros_Almacenes = Filtros.F_Almacenes.Select(f => f.Valor).ToList();

            /*  Filtro por Origenes de Movimiento   */
            if (Filtros.F_OrigenMovs.Count() > 0)
                Filtros_OMovs = Filtros.F_OrigenMovs.Select(f => f.Valor).ToList();

            /*  Filtro por Productos  */
            if (Filtros.F_Productos.Count() > 0)
                Filtros_Productos = Filtros.F_Productos.Select(f => f.Valor).ToList();

            return _context.InMovimientos.Where(movs =>
                (Filtros_Llaves.Count > 0 ? Filtros_Llaves.Contains(movs.InMovimientoId) : true) &&
                (Filtros_Almacenes.Count > 0 ? Filtros_Almacenes.Contains(movs.AlmacenId) : true) &&
                (Filtros_OMovs.Count > 0 ? Filtros_OMovs.Contains(movs.OrigenMovId) : true) &&
                (Filtros_Productos.Count > 0 ? Filtros_Productos.Contains(movs.InProductoId) : true)
            ).ToList();
        }

        // GET: api/Movimiento/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInMovimientos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inMovimientos = await _context.InMovimientos.FindAsync(id);

            if (inMovimientos == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return Ok(inMovimientos);
        }

        // PUT: api/Movimiento/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInMovimientos([FromRoute] int id, [FromBody] InMovimientos inMovimientos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inMovimientos.InMovimientoId)
            {
                return BadRequest();
            }

            _context.Entry(inMovimientos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InMovimientosExists(id))
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

        // POST: api/Movimiento
        [HttpPost]
        public async Task<IActionResult> PostInMovimientos([FromBody] InMovimientos inMovimientos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.InMovimientos.Add(inMovimientos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInMovimientos", new { id = inMovimientos.InMovimientoId }, inMovimientos);
        }

        //  POST: api/Movimiento/Multiple
        [HttpPost("Multiple")]
        [ActionName("Multiple")]
        public async Task<IActionResult> PostListInMovimientos([FromBody] List<InMovimientos> ListaInMovimientos)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                //IEnumerable<Claim> claims = identity.Claims;
                var usuario_actual = identity.FindFirst("Email").Value;
                Console.Write("usuario Leido <Post.InMovimiento.Multiple>: " + usuario_actual);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            List<InMovimientos> listaResultados = new List<InMovimientos>();
            foreach (var item in ListaInMovimientos)
            {
                _context.Add(item);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    item.InMovimientoId = -1;
                    item.InMovimientoObs = "ERROR EN POST API" + item.InMovimientoObs;
                }
                finally
                {
                    listaResultados.Add(item);
                }
            }
            return CreatedAtAction("GetInMovimientos", listaResultados);
        }

        // DELETE: api/Movimiento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInMovimientos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inMovimientos = await _context.InMovimientos.FindAsync(id);
            if (inMovimientos == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.InMovimientos.Remove(inMovimientos);
            await _context.SaveChangesAsync();

            return Ok(inMovimientos);
        }

        private bool InMovimientosExists(int id)
        {
            return _context.InMovimientos.Any(e => e.InMovimientoId == id);
        }
    }
}
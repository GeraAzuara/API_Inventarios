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
    public class CveProdServ_CPController : ControllerBase
    {
        private readonly FullDBContext _context;

        public CveProdServ_CPController(FullDBContext context)
        {
            _context = context;
        }

        #region Métodos consumidos en produccion
        // GET: api/CveProdServ_CP
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cveprodservcp>>> GetCveprodservcp()
        {
            return await _context.Cveprodservcp.ToListAsync();
        }
        // GET: api/CveProdServ_CP/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cveprodservcp>> GetCveprodservcp(string id)
        {
            var cveprodservcp = await _context.Cveprodservcp.FindAsync(id);

            if (cveprodservcp == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            return cveprodservcp;
        }
        #endregion

        #region Funcionalidad inutilizada en produccion
        // PUT: api/CveProdServ_CP/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCveprodservcp(string id, Cveprodservcp cveprodservcp)
        {
            if (id != cveprodservcp.CveProdServCpid)
            {
                return BadRequest();
            }

            _context.Entry(cveprodservcp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CveprodservcpExists(id))
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
        // POST: api/CveProdServ_CP
        [HttpPost]
        public async Task<ActionResult<Cveprodservcp>> PostCveprodservcp(Cveprodservcp cveprodservcp)
        {
            _context.Cveprodservcp.Add(cveprodservcp);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CveprodservcpExists(cveprodservcp.CveProdServCpid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCveprodservcp", new { id = cveprodservcp.CveProdServCpid }, cveprodservcp);
        }

        // DELETE: api/CveProdServ_CP/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cveprodservcp>> DeleteCveprodservcp(string id)
        {
            var cveprodservcp = await _context.Cveprodservcp.FindAsync(id);
            if (cveprodservcp == null)
            {
                return NotFound("Registro(s) no encontado(s).");
            }

            _context.Cveprodservcp.Remove(cveprodservcp);
            await _context.SaveChangesAsync();

            return cveprodservcp;
        }

        private bool CveprodservcpExists(string id)
        {
            return _context.Cveprodservcp.Any(e => e.CveProdServCpid == id);
        }

        #endregion
    }
}

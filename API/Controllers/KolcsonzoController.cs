using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using ClassLibrary.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KolcsonzoController : ControllerBase
    {
        private readonly APIContext _context;

        public KolcsonzoController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Kolcsonzo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kolcsonzo>>> GetKolcsonzo()
        {
          if (_context.Kolcsonzo == null)
          {
              return NotFound();
          }
            return await _context.Kolcsonzo.Include(x => x.Kolcsonzes).ToListAsync();
        }

        // GET: api/Kolcsonzo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kolcsonzo>> GetKolcsonzo(int id)
        {
          if (_context.Kolcsonzo == null)
          {
              return NotFound();
          }
            var kolcsonzo = await _context.Kolcsonzo.Where(X => X.Id == id).Include(x => x.Kolcsonzes).FirstOrDefaultAsync();

            if (kolcsonzo == null)
            {
                return NotFound();
            }

            return kolcsonzo;
        }

        // PUT: api/Kolcsonzo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKolcsonzo(int id, Kolcsonzo kolcsonzo)
        {
            if (id != kolcsonzo.Id)
            {
                return BadRequest();
            }

            _context.Entry(kolcsonzo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KolcsonzoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Kolcsonzo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kolcsonzo>> PostKolcsonzo(Kolcsonzo kolcsonzo)
        {
          if (_context.Kolcsonzo == null)
          {
              return Problem("Entity set 'APIContext.Kolcsonzo'  is null.");
          }
            _context.Kolcsonzo.Add(kolcsonzo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKolcsonzo", new { id = kolcsonzo.Id }, kolcsonzo);
        }

        // DELETE: api/Kolcsonzo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKolcsonzo(int id)
        {
            if (_context.Kolcsonzo == null)
            {
                return NotFound();
            }
            var kolcsonzo = await _context.Kolcsonzo.FindAsync(id);
            if (kolcsonzo == null)
            {
                return NotFound();
            }

            _context.Kolcsonzo.Remove(kolcsonzo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KolcsonzoExists(int id)
        {
            return (_context.Kolcsonzo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

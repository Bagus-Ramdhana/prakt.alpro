using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bank.Models;

namespace alpro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class nasabahController : ControllerBase
    {
        private readonly dbbank _context;

        public nasabahController(dbbank context)
        {
            _context = context;
        }

        // GET: api/nasabah
        [HttpGet]
        public async Task<ActionResult<IEnumerable<nasabah>>> Getnasabah()
        {
            return await _context.nasabah.ToListAsync();
        }

        // GET: api/nasabah/5
        [HttpGet("{id}")]
        public async Task<ActionResult<nasabah>> Getnasabah(string id)
        {
            var nasabah = await _context.nasabah.FindAsync(id);

            if (nasabah == null)
            {
                return NotFound();
            }

            return nasabah;
        }

        // PUT: api/nasabah/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putnasabah(string id, nasabah nasabah)
        {
            if (id != nasabah.ciff_nasabah)
            {
                return BadRequest();
            }

            _context.Entry(nasabah).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!nasabahExists(id))
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

        // POST: api/nasabah
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<nasabah>> Postnasabah(nasabah nasabah)
        {
            _context.nasabah.Add(nasabah);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (nasabahExists(nasabah.ciff_nasabah))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Getnasabah", new { id = nasabah.ciff_nasabah }, nasabah);
        }

        // DELETE: api/nasabah/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletenasabah(string id)
        {
            var nasabah = await _context.nasabah.FindAsync(id);
            if (nasabah == null)
            {
                return NotFound();
            }

            _context.nasabah.Remove(nasabah);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool nasabahExists(string id)
        {
            return _context.nasabah.Any(e => e.ciff_nasabah == id);
        }
    }
}

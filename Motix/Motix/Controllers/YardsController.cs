using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motix.API.Domain;
using Motix.API.Infrastructure.Context;

namespace Motix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YardsController : ControllerBase
    {
        private readonly MotixContext _context;

        public YardsController(MotixContext context)
        {
            _context = context;
        }

        // GET: api/Yards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Yard>>> GetYards()
        {
            return await _context.Yards.ToListAsync();
        }

        // GET: api/Yards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Yard>> GetYard(int id)
        {
            var yard = await _context.Yards.FindAsync(id);

            if (yard == null)
            {
                return NotFound();
            }

            return yard;
        }

        // PUT: api/Yards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYard(int id, Yard yard)
        {
            if (id != yard.Id)
            {
                return BadRequest();
            }

            _context.Entry(yard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YardExists(id))
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

        // POST: api/Yards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Yard>> PostYard(Yard yard)
        {
            _context.Yards.Add(yard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYard", new { id = yard.Id }, yard);
        }

        // DELETE: api/Yards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYard(int id)
        {
            var yard = await _context.Yards.FindAsync(id);
            if (yard == null)
            {
                return NotFound();
            }

            _context.Yards.Remove(yard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YardExists(int id)
        {
            return _context.Yards.Any(e => e.Id == id);
        }
    }
}

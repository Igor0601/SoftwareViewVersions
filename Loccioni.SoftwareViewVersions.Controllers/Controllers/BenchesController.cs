using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Loccioni.SoftwareViewVersions.DataModels;
using Loccioni.SoftwareViewVersions.Db;

namespace Loccioni.SoftwareViewVersions.Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenchesController : ControllerBase
    {
        private readonly LoccioniDbContext _context;

        public BenchesController(LoccioniDbContext context)
        {
            _context = context;
        }

        // GET: api/Benches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bench>>> Getbenches()
        {
            return await _context.benches.ToListAsync();
        }

        // GET: api/Benches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bench>> GetBench(int id)
        {
            var bench = await _context.benches.FindAsync(id);

            if (bench == null)
            {
                return NotFound();
            }

            return bench;
        }

        // PUT: api/Benches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBench(int id, Bench bench)
        {
            if (id != bench.Id)
            {
                return BadRequest();
            }

            _context.Entry(bench).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BenchExists(id))
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

        // POST: api/Benches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bench>> PostBench(Bench bench)
        {
            _context.benches.Add(bench);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBench", new { id = bench.Id }, bench);
        }

        // DELETE: api/Benches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBench(int id)
        {
            var bench = await _context.benches.FindAsync(id);
            if (bench == null)
            {
                return NotFound();
            }

            _context.benches.Remove(bench);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BenchExists(int id)
        {
            return _context.benches.Any(e => e.Id == id);
        }
    }
}

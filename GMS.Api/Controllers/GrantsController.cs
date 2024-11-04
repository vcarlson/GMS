using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMS.Api.Models; // Make sure to include your models namespace
using GMS.Api.Data;   // Ensure this matches your DbContext namespace

namespace GMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrantsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GrantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/grants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grant>>> GetGrants()
        {
            return await _context.Grants.ToListAsync();
        }

        // GET: api/grants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grant>> GetGrant(int id)
        {
            var grant = await _context.Grants.FindAsync(id);

            if (grant == null)
            {
                return NotFound();
            }

            return grant;
        }

        // POST: api/grants
        [HttpPost]
        public async Task<ActionResult<Grant>> PostGrant(Grant grant)
        {
            _context.Grants.Add(grant);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGrant), new { id = grant.Id }, grant);
        }

        // PUT: api/grants/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrant(int id, Grant grant)
        {
            if (id != grant.Id)
            {
                return BadRequest();
            }

            _context.Entry(grant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrantExists(id))
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

        // DELETE: api/grants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrant(int id)
        {
            var grant = await _context.Grants.FindAsync(id);
            if (grant == null)
            {
                return NotFound();
            }

            _context.Grants.Remove(grant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GrantExists(int id)
        {
            return _context.Grants.Any(e => e.Id == id);
        }
    }
}

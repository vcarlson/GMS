using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class GrantApplicationsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public GrantApplicationsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/GrantApplications
    [HttpGet]
    public async Task<ActionResult<IEnumerable<GrantApplication>>> GetGrantApplications()
    {
        return await _context.GrantApplications.ToListAsync();
    }

    // GET: api/GrantApplications/5
    [HttpGet("{id}")]
    public async Task<ActionResult<GrantApplication>> GetGrantApplication(int id)
    {
        var grantApplication = await _context.GrantApplications.FindAsync(id);

        if (grantApplication == null)
        {
            return NotFound();
        }

        return grantApplication;
    }

    // POST: api/GrantApplications
    [HttpPost]
    public async Task<ActionResult<GrantApplication>> PostGrantApplication(GrantApplication grantApplication)
    {
        _context.GrantApplications.Add(grantApplication);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetGrantApplication), new { id = grantApplication.Id }, grantApplication);
    }

    // PUT: api/GrantApplications/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutGrantApplication(int id, GrantApplication grantApplication)
    {
        if (id != grantApplication.Id)
        {
            return BadRequest();
        }

        _context.Entry(grantApplication).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!GrantApplicationExists(id))
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

    // DELETE: api/GrantApplications/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGrantApplication(int id)
    {
        var grantApplication = await _context.GrantApplications.FindAsync(id);
        if (grantApplication == null)
        {
            return NotFound();
        }

        _context.GrantApplications.Remove(grantApplication);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool GrantApplicationExists(int id)
    {
        return _context.GrantApplications.Any(e => e.Id == id);
    }
}

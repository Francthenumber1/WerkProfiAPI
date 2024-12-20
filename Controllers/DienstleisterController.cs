using Microsoft.AspNetCore.Mvc;
using WerkProfiAPI.Models;
using Microsoft.EntityFrameworkCore;
using WerkProfiAPI; // Add this line to include the namespace where WerkProfiContext is defined

[Route("api/[controller]")]
[ApiController]
public class DienstleisterController : ControllerBase
{
    private readonly WerkProfiContext _context;

    public DienstleisterController(WerkProfiContext context)
    {
        _context = context;
    }

    // GET: api/Dienstleister
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dienstleister>>> GetDienstleister()
    {
        return await _context.Dienstleister.ToListAsync();
    }

    // POST: api/Dienstleister
    [HttpPost]
    public async Task<ActionResult<Dienstleister>> PostDienstleister(Dienstleister dienstleister)
    {
        _context.Dienstleister.Add(dienstleister);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetDienstleister), new { id = dienstleister.Id }, dienstleister);
    }
}
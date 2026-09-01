using GridironIQ.Core.Entities;
using GridironIQ.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GridironIQ.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PlayersController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GetAll and GetById go below, using _context instead of Players


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Player>>> GetAll(string? position = null, string? team = null)
    {
        IQueryable<Player> query = _context.Players;

        if (position != null)
        {
            query = query.Where(p => p.Position.ToLower() == position.ToLower());
        }

        if (team != null)
        {
            query = query.Where(p => p.Team.ToLower() == team.ToLower());
        }

        return Ok(await query.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Player>> GetById(int id)
    {
        var player = await _context.Players.FirstOrDefaultAsync(p => p.Id == id);
        if (player is null)
        {
            return NotFound();
        }

        return Ok(player);
    }
}
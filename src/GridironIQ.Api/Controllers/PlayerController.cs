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
            query = query.Where(p => p.Team.Abbreviation.ToLower() == team.ToLower());
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

    [HttpGet("{id}/game-logs")]
    public async Task<ActionResult<IEnumerable<GameLog>>> GetGameLogs(
        int id,
        int? season = null,
        int? week = null)
    {
        var playerExists = await _context.Players.AnyAsync(player => player.Id == id);

        if (!playerExists)
        {
            return NotFound();
        }

        IQueryable<GameLog> query = _context.GameLogs
            .Where(gameLog => gameLog.PlayerId == id);

        if (season is not null)
        {
            query = query.Where(gameLog => gameLog.Season == season);
        }

        if (week is not null)
        {
            query = query.Where(gameLog => gameLog.Week == week);
        }

        return Ok(await query.ToListAsync());
    }

    [HttpGet("{id}/projections")]
    public async Task<ActionResult<IEnumerable<Projection>>> GetProjections(
        int id,
        int? season = null,
        int? week = null)
    {
        var playerExists = await _context.Players.AnyAsync(player => player.Id == id);

        if (!playerExists)
        {
            return NotFound();
        }

        IQueryable<Projection> query = _context.Projections
            .Where(projection => projection.PlayerId == id);

        if (season is not null)
        {
            query = query.Where(projection => projection.Season == season);
        }

        if (week is not null)
        {
            query = query.Where(projection => projection.Week == week);
        }

        return Ok(await query.ToListAsync());
    }
}
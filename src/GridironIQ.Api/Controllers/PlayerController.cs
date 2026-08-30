using GridironIQ.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GridironIQ.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private static readonly List<Player> Players = new()
    {
        new Player
        {
            Id = 1,
            Name = "Christian McCaffrey",
            Team = "SF",
            Position = "RB"
        },
        new Player
        {
            Id = 2,
            Name = "Trevor Lawrence",
            Team = "JAX",
            Position = "QB"
        },
        new Player
        {
            Id = 3,
            Name = "DeVonta Smith",
            Team = "PHI",
            Position = "WR"
        },
        new Player
        {
            Id = 4,
            Name = "Cooper DeJean",
            Team = "PHI",
            Position = "CB"
        },
        new Player
        {
            Id = 5,
            Name = "Jalen Carter",
            Team = "PHI",
            Position = "DT"
        }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Player>> GetAll()
    {
        return Ok(Players);
    }

    [HttpGet("{id}")]
    public ActionResult<Player> GetById(int id)
    {
        var player = Players.FirstOrDefault(p => p.Id == id);
        if (player is null)
        {
            return NotFound();
        }

        return Ok(player);
    }
}
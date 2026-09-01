using GridironIQ.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace GridironIQ.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Player> Players => Set<Player>();
    public DbSet<Team> Teams => Set<Team>();
    public DbSet<GameLog> GameLogs => Set<GameLog>();
    public DbSet<Projection> Projections => Set<Projection>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>().HasData(
            new Player { Id = 1, Name = "Christian McCaffrey", Team = "SF", Position = "RB" },
            new Player { Id = 2, Name = "Trevor Lawrence", Team = "JAX", Position = "QB" },
            new Player { Id = 3, Name = "DeVonta Smith", Team = "PHI", Position = "WR" },
            new Player { Id = 4, Name = "Cooper DeJean", Team = "PHI", Position = "CB" },
            new Player { Id = 5, Name = "Jalen Carter", Team = "PHI", Position = "DT" }
        );
    }
}
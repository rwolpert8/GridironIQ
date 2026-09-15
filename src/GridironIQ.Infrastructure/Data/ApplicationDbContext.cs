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
            new Player { Id = 1, Name = "Christian McCaffrey", TeamId = 1, Position = "RB" },
            new Player { Id = 2, Name = "Trevor Lawrence", TeamId = 2, Position = "QB" },
            new Player { Id = 3, Name = "DeVonta Smith", TeamId = 3, Position = "WR" },
            new Player { Id = 4, Name = "Cooper DeJean", TeamId = 3, Position = "CB" },
            new Player { Id = 5, Name = "Jalen Carter", TeamId = 3, Position = "DT" }
        );

        modelBuilder.Entity<GameLog>().HasData(
            new GameLog
            {
                Id = 1,
                PlayerId = 1,
                Season = 2025,
                Week = 1,
                Opponent = "SEA",
                FantasyPoints = 18.4,
                PassingYards = 0,
                RushingYards = 86,
                ReceivingYards = 42,
                Touchdowns = 1
            }
        );

        modelBuilder.Entity<Projection>().HasData(
            new Projection
            {
                Id = 1,
                PlayerId = 1,
                Season = 2026,
                Week = 2,
                ProjectedPoints = 19.2
            }
        );

        modelBuilder.Entity<Team>().HasData(
            new Team
            {
                Id = 1,
                Name = "San Francisco 49ers",
                Abbreviation = "SF",
                Conference = "NFC",
                Division = "West"
            },
            new Team
            {
                Id = 2,
                Name = "Jacksonville Jaguars",
                Abbreviation = "JAX",
                Conference = "AFC",
                Division = "South"
            },
            new Team
            {
                Id = 3,
                Name = "Philadelphia Eagles",
                Abbreviation = "PHI",
                Conference = "NFC",
                Division = "East"
            }
        );
    }
}
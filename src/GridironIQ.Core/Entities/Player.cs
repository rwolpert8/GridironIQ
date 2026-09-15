namespace GridironIQ.Core.Entities;
// Player entity class - need ID number, name, team, position
public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TeamId{ get; set; } = 0;
    public string Position { get; set; } = string.Empty;

    public Team Team { get; set; } = null!;
    public ICollection<GameLog> GameLogs { get; set; } = new List<GameLog>();
    public ICollection<Projection> Projections { get; set; } = new List<Projection>();
}
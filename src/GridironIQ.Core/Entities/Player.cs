namespace GridironIQ.Core.Entities;
// Player entity class - need ID number, name, team, position
public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Team { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
}
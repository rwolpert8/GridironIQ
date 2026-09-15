namespace GridironIQ.Core.Entities;

public class Projection
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int Season { get; set; }
    public int Week { get; set; }
    public double ProjectedPoints { get; set; }
    public Player Player { get; set; } = null!;
}

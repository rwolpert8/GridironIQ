namespace GridironIQ.Core.Entities;

public class GameLog
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int Season { get; set; }
    public int Week { get; set; }
    public string Opponent { get; set; } = string.Empty;
    public double FantasyPoints { get; set; }
    public int PassingYards { get; set; }
    public int RushingYards { get; set; }
    public int ReceivingYards { get; set; }
    public int Touchdowns { get; set; }
}

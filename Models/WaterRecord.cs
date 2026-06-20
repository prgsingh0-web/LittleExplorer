namespace ToddlerActivityPlanner.Models;

public class WaterRecord
{
    public int Id { get; set; }
    public int CupsDrank { get; set; }
    public int ChildId { get; set; }
    public DateTime Date { get; set; } = DateTime.Today;
}
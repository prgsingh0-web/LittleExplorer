namespace ToddlerActivityPlanner.Models;

public class GrowthRecord
{
    public int Id { get; set; }

    public int ChildId { get; set; }

    public decimal WeightKg { get; set; }

    public decimal HeightCm { get; set; }

    public DateTime RecordDate { get; set; } = DateTime.Today;
}
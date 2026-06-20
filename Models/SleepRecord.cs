namespace ToddlerActivityPlanner.Models;

public class SleepRecord
{
    public int Id { get; set; }

    public DateTime BedTime { get; set; }

    public DateTime WakeTime { get; set; }

    public string Notes { get; set; } = "";

    public int ChildId { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
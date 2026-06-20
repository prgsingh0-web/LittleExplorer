namespace ToddlerActivityPlanner.Models;

public class Activity
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Category { get; set; } = "Learning";

    public int DurationMinutes { get; set; } = 15;

    public bool IsCompleted { get; set; } = false;

    public int ChildId { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
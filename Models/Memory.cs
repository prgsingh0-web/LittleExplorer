namespace ToddlerActivityPlanner.Models;

public class Memory
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public string Notes { get; set; } = "";

    public int ChildId { get; set; }

    public DateTime MemoryDate { get; set; } = DateTime.Today;

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public string PhotoPath { get; set; } = "";
}
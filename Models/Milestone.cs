namespace ToddlerActivityPlanner.Models;

public class Milestone
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public string Category { get; set; } = "Language";

    public string AgeRange { get; set; } = "";

    public bool IsCompleted { get; set; }

    public DateTime? DateCompleted { get; set; }

    public int ChildId { get; set; }

    public Child? Child { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
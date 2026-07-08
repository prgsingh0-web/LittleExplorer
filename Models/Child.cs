namespace ToddlerActivityPlanner.Models;

public class Child
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public int? Age { get; set; }

    public string PhotoPath { get; set; } = "";

    public bool IsActive { get; set; } = false;

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public string UserId { get; set; } = "";
    public ApplicationUser? User { get; set; }


}
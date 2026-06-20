namespace ToddlerActivityPlanner.Models;

public class Meal
{
    public int Id { get; set; }

    public string MealType { get; set; } = "Breakfast";

    public string FoodName { get; set; } = "";

    public TimeSpan MealTime { get; set; } = DateTime.Now.TimeOfDay;

    public string Notes { get; set; } = "";

    public bool IsEaten { get; set; } = false;

    public int ChildId { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
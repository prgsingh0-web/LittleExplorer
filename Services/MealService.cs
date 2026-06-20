using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Models;

namespace ToddlerActivityPlanner.Services;

public class MealService
{
    private readonly AppDbContext _db;

    public MealService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Meal>> GetAllAsync(int childId)
    {
        return await _db.Meals
            .Where(m => m.ChildId == childId)
            .OrderByDescending(m => m.CreatedDate)
            .ToListAsync();
    }

    public async Task AddAsync(Meal meal)
    {
        _db.Meals.Add(meal);
        await _db.SaveChangesAsync();
    }

    public async Task ToggleEatenAsync(int id)
    {
        var meal = await _db.Meals.FindAsync(id);

        if (meal != null)
        {
            meal.IsEaten = !meal.IsEaten;
            await _db.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(int id)
    {
        var meal = await _db.Meals.FindAsync(id);

        if (meal != null)
        {
            _db.Meals.Remove(meal);
            await _db.SaveChangesAsync();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Models;

namespace ToddlerActivityPlanner.Services;

public class ActivityService
{
    private readonly AppDbContext _db;

    public ActivityService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Activity>> GetAllAsync(int childId)
    {
        return await _db.Activities
            .Where(a => a.ChildId == childId)
            .OrderByDescending(a => a.CreatedDate)
            .ToListAsync();
    }

    public async Task AddAsync(Activity activity)
    {
        _db.Activities.Add(activity);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var activity = await _db.Activities.FindAsync(id);

        if (activity != null)
        {
            _db.Activities.Remove(activity);
            await _db.SaveChangesAsync();
        }
    }

    public async Task ToggleCompleteAsync(int id)
    {
        var activity = await _db.Activities.FindAsync(id);

        if (activity != null)
        {
            activity.IsCompleted = !activity.IsCompleted;
            await _db.SaveChangesAsync();
        }
    }
}
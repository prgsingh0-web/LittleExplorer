using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Models;

namespace ToddlerActivityPlanner.Services;

public class ChildService
{
    private readonly AppDbContext _db;

    public ChildService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Child>> GetAllAsync(string userId)
    {
        return await _db.Children
            .Where(c => c.UserId == userId)
            .OrderByDescending(c => c.CreatedDate)
            .ToListAsync();
    }

    public async Task<List<Child>> GetAllAsync()
    {
        return await _db.Children
            .OrderByDescending(c => c.CreatedDate)
            .ToListAsync();
    }

    public async Task AddAsync(Child child)
    {
        _db.Children.Add(child);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var child = await _db.Children.FindAsync(id);

        if (child != null)
        {
            _db.Children.Remove(child);
            await _db.SaveChangesAsync();
        }
    }

    public async Task SetActiveAsync(int childId, string userId)
    {
        var children = await _db.Children
            .Where(c => c.UserId == userId)
            .ToListAsync();

        foreach (var child in children)
        {
            child.IsActive = child.Id == childId;
        }

        await _db.SaveChangesAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Models;

namespace ToddlerActivityPlanner.Services;

public class GrowthService
{
    private readonly AppDbContext _db;

    public GrowthService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<GrowthRecord>> GetAllAsync(int childId)
    {
        return await _db.GrowthRecords
            .Where(g => g.ChildId == childId)
            .OrderByDescending(g => g.RecordDate)
            .ToListAsync();
    }

    public async Task AddAsync(GrowthRecord record)
    {
        _db.GrowthRecords.Add(record);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var record = await _db.GrowthRecords.FindAsync(id);

        if (record != null)
        {
            _db.GrowthRecords.Remove(record);
            await _db.SaveChangesAsync();
        }
    }
}
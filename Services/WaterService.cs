using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Models;

namespace ToddlerActivityPlanner.Services;

public class WaterService
{
    private readonly AppDbContext _db;

    public WaterService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<WaterRecord>> GetAllAsync(int childId)
    {
        return await _db.WaterRecords
            .Where(w => w.ChildId == childId)
            .ToListAsync();
    }

    public async Task AddAsync(WaterRecord record)
    {
        _db.WaterRecords.Add(record);
        await _db.SaveChangesAsync();
    }
}
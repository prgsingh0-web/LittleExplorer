using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Models;

namespace ToddlerActivityPlanner.Services;

public class SleepService
{
    private readonly AppDbContext _db;

    public SleepService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<SleepRecord>> GetAllAsync(int childId)
    {
        return await _db.SleepRecords
            .Where(s => s.ChildId == childId)
            .OrderByDescending(s => s.CreatedDate)
            .ToListAsync();
    }

    public async Task AddAsync(SleepRecord record)
    {
        _db.SleepRecords.Add(record);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var record = await _db.SleepRecords.FindAsync(id);

        if (record != null)
        {
            _db.SleepRecords.Remove(record);
            await _db.SaveChangesAsync();
        }
    }
}
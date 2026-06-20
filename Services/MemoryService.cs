using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Models;

namespace ToddlerActivityPlanner.Services;

public class MemoryService
{
    private readonly AppDbContext _db;

    public MemoryService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Memory>> GetAllAsync(int childId)
    {
        return await _db.Memories
            .Where(m => m.ChildId == childId)
            .OrderByDescending(m => m.MemoryDate)
            .ToListAsync();
    }

    public async Task AddAsync(Memory memory)
    {
        _db.Memories.Add(memory);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var memory = await _db.Memories.FindAsync(id);

        if (memory != null)
        {
            _db.Memories.Remove(memory);
            await _db.SaveChangesAsync();
        }
    }
}
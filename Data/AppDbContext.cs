using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Models;


namespace ToddlerActivityPlanner.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Activity> Activities => Set<Activity>();
    public DbSet<Meal> Meals => Set<Meal>();
    public DbSet<SleepRecord> SleepRecords => Set<SleepRecord>();
    public DbSet<WaterRecord> WaterRecords => Set<WaterRecord>();
    public DbSet<Child> Children => Set<Child>();
    public DbSet<Memory> Memories => Set<Memory>();
    public DbSet<GrowthRecord> GrowthRecords => Set<GrowthRecord>();
}
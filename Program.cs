using Microsoft.EntityFrameworkCore;
using ToddlerActivityPlanner.Components;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=activities.db"));

builder.Services.AddScoped<ActivityService>();
builder.Services.AddScoped<MealService>();
builder.Services.AddScoped<SleepService>();
builder.Services.AddScoped<WaterService>();
builder.Services.AddScoped<ChildService>();
builder.Services.AddScoped<MemoryService>();
builder.Services.AddScoped<GrowthService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

app.Run();

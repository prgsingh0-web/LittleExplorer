using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ToddlerActivityPlanner.Components;
using ToddlerActivityPlanner.Data;
using ToddlerActivityPlanner.Services;
using ToddlerActivityPlanner.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=activities.db"));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();

builder.Services.AddRazorPages(); 


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

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}
app.MapRazorPages();

app.MapPost("/login-user", async (
    HttpContext httpContext,
    SignInManager<ApplicationUser> signInManager) =>
{
    var form = await httpContext.Request.ReadFormAsync();

    var email = form["email"].ToString();
    var password = form["password"].ToString();

    var result = await signInManager.PasswordSignInAsync(
        email,
        password,
        isPersistent: true,
        lockoutOnFailure: false);

    if (result.Succeeded)
    {
        return Results.Redirect("/dashboard");
    }

    return Results.Redirect("/login?error=1");
});

app.Run();
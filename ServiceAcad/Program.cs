using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add PostgreSQL and Identity services
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

// Build the app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Enable authentication and authorization
app.UseAuthentication(); // Ensure this comes before UseAuthorization
app.UseAuthorization();

// Default route for standard controllers (HomeController, etc.)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Route for AdminDashboardController
app.MapControllerRoute(
    name: "admin",
    pattern: "Admin/{action=Index}/{id?}",
    defaults: new { controller = "AdminDashboard", action = "Index" });

// Route for StudentDashboardController
app.MapControllerRoute(
    name: "student",
    pattern: "Student/{action=Index}/{id?}",
    defaults: new { controller = "StudentDashboard", action = "Index" });

// Route for InstructorDashboardController
app.MapControllerRoute(
    name: "instructor",
    pattern: "Instructor/{action=Index}/{id?}",
    defaults: new { controller = "InstructorDashboard", action = "Index" });

// Run the app
app.Run();

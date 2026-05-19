using ECommerceFiltersApp.Filters;
using ECommerceFiltersApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<GlobalExceptionFilter>();
    options.Filters.Add<LoggingFilter>();
});

builder.Services.AddScoped<ILoggingService, LoggingService>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddScoped<AuthFilter>();
builder.Services.AddScoped<LoggingFilter>();
builder.Services.AddScoped<GlobalExceptionFilter>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
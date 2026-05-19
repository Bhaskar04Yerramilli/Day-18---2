using BankingFiltersApp.Filters;
using BankingFiltersApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<LoggingFilter>();
    options.Filters.Add<ExceptionFilter>();
});

builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<LoggingService>();

builder.Services.AddScoped<AuthenticationFilter>();
builder.Services.AddScoped<AuthorizationFilter>();
builder.Services.AddScoped<LoggingFilter>();
builder.Services.AddScoped<ExceptionFilter>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bank}/{action=Index}/{id?}");

app.Run();
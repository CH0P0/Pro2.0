var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddRazorPages();

app.UseStaticFiles();

app.MapRazorPages();

app.Run();

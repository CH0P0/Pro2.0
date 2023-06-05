using Microsoft.EntityFrameworkCore;
using ProyectoRazor.Models;
using System.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddDbContext<DiscosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MiDataBase") ?? throw new InvalidOperationException
    ("Connection string 'MiDataBase' not found")));


var app = builder.Build();

app.MapRazorPages();

app.Run();

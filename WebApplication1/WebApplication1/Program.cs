using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace WebApplication1
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorPages();
            var app = builder.Build();

            app.MapRazorPages();

            app.Run();
        }
    }
}
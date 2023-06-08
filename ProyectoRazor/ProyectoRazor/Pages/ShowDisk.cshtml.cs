using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazor.Models;

namespace ProyectoRazor.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class ShowDiskModel : PageModel
    {
        public readonly DiscosContext Datos;

        public ShowDiskModel(DiscosContext datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}

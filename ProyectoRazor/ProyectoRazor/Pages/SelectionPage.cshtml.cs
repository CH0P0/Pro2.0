using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazor.Models;

namespace ProyectoRazor.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class SelectionPageModel : PageModel
    {
        public readonly DiscosContext Datos;

        public SelectionPageModel(DiscosContext datos)
        {
            Datos = datos;
        }

        public void OnGet()
        {
        }
    }
}

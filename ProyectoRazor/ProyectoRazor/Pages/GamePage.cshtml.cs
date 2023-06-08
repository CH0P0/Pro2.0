using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazor.Models;

namespace ProyectoRazor.Pages
{
	[IgnoreAntiforgeryToken(Order = 1001)]
	public class GamePageModel : PageModel
    {
        public readonly DiscosContext Datos;

        public GamePageModel(DiscosContext datos)
        {
            Datos = datos;
        }

        public void OnGet()
        {
        }
    }
}

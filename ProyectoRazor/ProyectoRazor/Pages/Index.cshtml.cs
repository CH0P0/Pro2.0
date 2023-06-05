using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazor.Models;

namespace ProyectoRazor.Pages
{
    public class IndexModel : PageModel
    {
        public readonly DiscosContext Datos;

        public IndexModel(DiscosContext Datos)
        {
            this.Datos = Datos;
        }

        public void OnGet()
        {
        }
    }
}

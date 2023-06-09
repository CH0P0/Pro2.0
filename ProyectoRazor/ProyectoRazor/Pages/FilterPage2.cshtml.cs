using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazor.Models;

namespace ProyectoRazor.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class FilterPage2Model : PageModel
    {
        public readonly DiscosContext Datos;

        public FilterPage2Model(DiscosContext datos)
        {
            Datos = datos;
        }

        public void OnGet()
        {
        }
    }
}

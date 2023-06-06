using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProyectoRazor.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class SelectionPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

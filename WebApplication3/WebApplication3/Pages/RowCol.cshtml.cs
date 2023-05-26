using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class RowColModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

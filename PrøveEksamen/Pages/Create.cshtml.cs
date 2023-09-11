using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrøveEksamen.Models;

namespace PrøveEksamen.Pages
{
    public class CreateModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

    }
}

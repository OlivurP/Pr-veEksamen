using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrøveEksamen.Data;
using PrøveEksamen.Models;

namespace PrøveEksamen.Pages
{
    public class BankModel : PageModel
    {

        public Int dbInjected;

        public BankModel(ILogger<IndexModel> logger, Int dbInd)
        {
            this.dbInjected = dbInd;
        }
        public void OnGet(Int dbInd)
        {
            this.dbInjected = dbInd;
        }
    }
}

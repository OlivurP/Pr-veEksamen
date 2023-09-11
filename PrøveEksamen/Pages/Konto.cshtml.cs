using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrøveEksamen.Data;
using PrøveEksamen.Models;

namespace PrøveEksamen.Pages
{
    public class KontoModel : PageModel
    {
        public static List<Bank> Banks { get; set; }
        public KontoModel(BankKontoInj bki)
        {
            
        }
        public Bank bank { get; set; }
        public int BankID { get; set; }

        public Int Int { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, Int intInject)
        {
            this.Int = intInject;
            if(id == null)
            {
                bank = new Bank();
                bank.Name = "Vælg bank først";
                return Page();
            }
            BankID = id.Value;
            foreach(Bank b in intInject.GetBanks())
            {
                if (b.Id == id)
                {
                    bank = b;
                }
            }
            return Page();
        }

        [BindProperty]
        public Konto Konto { get; set; }

        public async Task<IActionResult> OnPostAsync(int? id, Int intInject)
        {
            foreach (Bank b in intInject.GetBanks())
            {
                if (b.Id == id)
                {
                    if(b.KontoList == null)
                    {
                        b.KontoList = new List<Konto>();
                    }
                    b.KontoList.Add(Konto);
                }
            }

            return RedirectToPage("./Index");
        }
    }
}

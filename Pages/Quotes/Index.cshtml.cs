using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebVersion.Data;
using MegaDeskWebVersion.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskWebVersion.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWebVersion.Data.MegaDeskWebVersionContext _context;

        public IndexModel(MegaDeskWebVersion.Data.MegaDeskWebVersionContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string CustomerName { get; set; }
       

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            var quotes = from q in _context.DeskQuote
                         select q;
            if (!string.IsNullOrEmpty(CustomerName))
            {
                quotes = quotes.Where(s => s.CustomerName.Contains(CustomerName));
            }

            DeskQuote = await quotes.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebVersion.Data;
using MegaDeskWebVersion.Models;

namespace MegaDeskWebVersion.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWebVersion.Data.MegaDeskWebVersionContext _context;

        public IndexModel(MegaDeskWebVersion.Data.MegaDeskWebVersionContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}

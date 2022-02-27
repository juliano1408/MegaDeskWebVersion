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

        public string CustomerNameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync(string sortOrder)
        {
            CustomerNameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<DeskQuote> quotesIQ = from q in _context.DeskQuote
                         select q;

            if (!string.IsNullOrEmpty(CustomerName))
            {
                quotesIQ = quotesIQ.Where(s => s.CustomerName.Contains(CustomerName));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    quotesIQ = quotesIQ.OrderByDescending(q => q.CustomerName);
                    break;
                //case "Date":
                //    quotesIQ = quotesIQ.OrderBy(q => q.Date);
                    //break;
                //case "date_desc":
                //    quotesIQ = quotesIQ.OrderByDescending(q => q.EnrollmentDate);
                //    break;
                default:
                    quotesIQ = quotesIQ.OrderBy(q => q.CustomerName);
                    break;
            }
            
            DeskQuote = await quotesIQ.AsNoTracking().ToListAsync();
        }
    }
}

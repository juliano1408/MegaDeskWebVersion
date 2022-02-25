using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebVersion.Models;

namespace MegaDeskWebVersion.Data
{
    public class MegaDeskWebVersionContext : DbContext
    {
        public MegaDeskWebVersionContext (DbContextOptions<MegaDeskWebVersionContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskWebVersion.Models.DeskQuote> DeskQuote { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using MegaDeskWebVersion.Data;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MegaDeskWebVersion.Models

{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskWebVersionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskWebVersionContext>>()))
            {
                if (context == null || context.DeskQuote == null)
                {
                    throw new ArgumentNullException("Null MegaDeskWebVersionContext");
                }

                // Look for any quotes.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        CustomerName = "Carrick",
                        DeskWidth = 50,
                        DeskDepth = 85,
                        NumberDrawers = 7,
                        DesktopMaterial = "oak",
                        RushOrder = 3
                    },

                    new DeskQuote
                    {
                        CustomerName = "Brittany",
                        DeskWidth = 89,
                        DeskDepth = 39,
                        NumberDrawers = 1,
                        DesktopMaterial = "pine",
                        RushOrder = 7
                    },

                    new DeskQuote
                    {
                        CustomerName = "Angela",
                        DeskWidth = 45,
                        DeskDepth = 60,
                        NumberDrawers = 5,
                        DesktopMaterial = "veneer",
                        RushOrder = 0
                    },

                new DeskQuote
                    {
                        CustomerName = "Derwin",
                        DeskWidth = 43,
                        DeskDepth = 69,
                        NumberDrawers = 0,
                        DesktopMaterial = "oak",
                        RushOrder = 3
                    },

                new DeskQuote
                    {
                        CustomerName = "Lorraine",
                        DeskWidth = 61,
                        DeskDepth = 72,
                        NumberDrawers = 5,
                        DesktopMaterial = "rosewood",
                        RushOrder = 5
                    }
                    );
                context.SaveChanges();

            }

            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebVersion.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int NumberDrawers { get; set; }
        public string DesktopMaterial { get; set; }
        public int RushOrder { get; set; }
    }
}

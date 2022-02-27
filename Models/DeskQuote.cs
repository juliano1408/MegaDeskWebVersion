using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskWebVersion.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }

        [Range(24, 96)]
        [Required]
        public int DeskWidth { get; set; }

        [Range(24, 96)]
        [Required]
        public int DeskDepth { get; set; }

        [Range(0, 7)]
        [Required]
        public int NumberDrawers { get; set; }

        [Required]
        public string DesktopMaterial { get; set; }

        [RegularExpression(@"^(0|3|5|7)$")]
        [Required]
        public int RushOrder { get; set; }
    }
}

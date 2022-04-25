using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EngiePowerPlantTest.Models
{
    public class Powerplant
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public decimal Efficiency { get; set; }

        public decimal PMin { get; set; }

        [Required]
        public decimal PMax { get; set; }
    }
}

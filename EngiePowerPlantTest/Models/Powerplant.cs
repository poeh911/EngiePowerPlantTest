using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngiePowerPlantTest.Models
{
    public class Powerplant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Efficiency { get; set; }
        public decimal PMin { get; set; }
        public decimal PMax { get; set; }
    }
}
